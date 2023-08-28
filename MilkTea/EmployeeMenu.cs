using MilkTea.Controls;
using MilkTea.Formatter;
using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea
{
    public partial class EmployeeMenu : Form
    {
        private MoneyFormatter formatter = new MoneyFormatter();
        private Account acc;

        MilkteaDBContext db = new MilkteaDBContext();
        Dictionary<int, OrderDetail> orderedProducts = new Dictionary<int, OrderDetail>();
        Dictionary<int, List<OrderDetail>> orderedToppings = new Dictionary<int, List<OrderDetail>>();
        Dictionary<int, List<OrderTopping>> toppingControls = new Dictionary<int, List<OrderTopping>>();
        double? totalBill = 0;


        public EmployeeMenu()
        {
            InitializeComponent();
            var catIdList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).Select(c => c.CategoryId).ToArray();
            LoadMenu(catIdList);
            LoadCategory();
            LoadOrder();
        }

        public EmployeeMenu(Account ac)
        {
            InitializeComponent();
            var catIdList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).Select(c => c.CategoryId).ToArray();
            LoadMenu(catIdList);
            LoadCategory();
            LoadOrder();
            acc = ac;
        }

        private void LoadCategory()
        {
            var categoryList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).OrderBy(cat => cat.CategoryId).ToList();
            int size = categoryList.Count;

            if (pnlCategory.Controls.Count > 0)
            {
                pnlCategory.Controls.Clear();
            }

            Button btnAll = new Button();
            btnAll.Name = $"btnCategory";
            btnAll.Size = new Size(173, 83);
            btnAll.Text = "All Product";
            btnAll.Font = new Font("Segoe UI", 12);
            btnAll.Location = new Point(82, 16);
            btnAll.BackColor = Color.Khaki;
            btnAll.Click += btnCategory_Click;
            pnlCategory.Controls.Add(btnAll);

            Button[] buttons = new Button[size];
            for (int i = 0; i < size; i++)
            {
                buttons[i] = new Button();
                buttons[i].Name = $"btnCategory{i + 1}";
                buttons[i].Size = new Size(173, 83);
                buttons[i].Font = new Font("Segoe UI", 12);
                buttons[i].Text = categoryList[i].CategoryName;
                buttons[i].Location = new Point(82, (i + 1) * 89 + 16);
                buttons[i].BackColor = Color.Khaki;
                buttons[i].Click += btnCategory_Click;

                pnlCategory.Controls.Add(buttons[i]);
            }
        }

        private void btnCategory_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonName = button.Name;
                string[] parts = buttonName.Split(new string[] { "btnCategory" }, StringSplitOptions.None);

                if (parts.Length >= 2 && int.TryParse(parts[1], out int catId))
                {
                    LoadMenu(catId);
                }
                else
                {
                    var catIdList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).Select(c => c.CategoryId).ToArray();
                    LoadMenu(catIdList);
                }
            }
        }

        private void LoadMenu(params int[] catIdList)
        {
            if (pnlMenu.Controls.Count > 0)
            {
                pnlMenu.Controls.Clear();
            }

            var menu = db.Products.Where(x => catIdList.Contains(x.CategoryId)).ToList();


            if (menu.Count > 0)
            {
                int size = menu.Count;
                MenuItem[] menuItem = new MenuItem[size];
                Button[] btnAdd = new Button[size];
                int itemPerRow = 5;
                int countRow = -1;
                int countCol = 0;

                for (int i = 0; i < size; i++)
                {
                    if (i % itemPerRow == 0)
                    {
                        countRow++;
                        countCol = 0;
                    }

                    btnAdd[i] = new Button();
                    btnAdd[i].Name = $"{menu[i].ProductId}";
                    btnAdd[i].Size = new Size(67, 28);
                    btnAdd[i].Location = new Point(108 + countCol * 181, 8 + countRow * 273);
                    btnAdd[i].BackColor = Color.IndianRed;
                    btnAdd[i].ForeColor = SystemColors.ControlLightLight;
                    btnAdd[i].Text = "Add";
                    btnAdd[i].BringToFront();
                    btnAdd[i].Click += btnAdd_Click;

                    menuItem[i] = new MenuItem();
                    menuItem[i].Location = new Point(6 + countCol * 181, 6 + countRow * 273);
                    menuItem[i].ProductId = menu[i].ProductId;
                    menuItem[i].PropName = menu[i].ProductName;
                    menuItem[i].PropPrice = menu[i].Price;
                    if (menu[i].Image != null)
                    {
                        try
                        {
                            menuItem[i].PropImage = Image.FromFile(menu[i].Image);
                        }
                        catch (Exception ex)
                        {
                            menuItem[i].PropImage = Image.FromFile("C:\\Users\\Dinh Nguyen\\Pictures\\Milktea\\No-Image-Placeholder.svg.png");
                        }
                    }
                    menuItem[i].SendToBack();

                    countCol++;
                    pnlMenu.Controls.Add(btnAdd[i]);
                    pnlMenu.Controls.Add(menuItem[i]);
                }
            }
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            int productId = int.Parse(((Button)sender).Name);
            var product = db.Products.SingleOrDefault(x => x.ProductId == productId);
            ToppingSelect selectToppingForm = new ToppingSelect(product);
            selectToppingForm.OrderAdded += HandleOrderAdded;
            selectToppingForm.ShowDialog();
        }

        private void HandleOrderAdded(OrderDetail orderToAdd, List<OrderDetail> toppingToAdd)
        {
            bool added = false;
            //Check for existed Orders
            Dictionary<int, OrderDetail> existedOrders = new Dictionary<int, OrderDetail>();
            foreach (var keyValuePair in orderedProducts)
            {
                if (keyValuePair.Value.ProductId == orderToAdd.ProductId)
                {
                    existedOrders.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
            //If order existed
            if (existedOrders.Count > 0)
            {
                //If orderToAdd has toppings
                if (toppingToAdd.Count > 0)
                {
                    //Check in each order if having the same toppings
                    foreach (var keyValuePair in existedOrders)
                    {
                        //If the current order contains topping
                        if (orderedToppings.ContainsKey(keyValuePair.Key))
                        {
                            //Compare the toppings
                            var existedToppings = orderedToppings[keyValuePair.Key];
                            //If topping the same then increase quantity
                            if (isSameTopping(existedToppings, toppingToAdd))
                            {
                                //Increase product's quantity and totalPrice
                                keyValuePair.Value.TotalPrice += orderToAdd.TotalPrice;
                                keyValuePair.Value.Quantity += orderToAdd.Quantity;
                                //Increase topping's quantity and totalPrice
                                foreach (OrderDetail t in existedToppings)
                                {
                                    var curTopping = toppingToAdd.SingleOrDefault(x => x.ProductId == t.ProductId);
                                    t.Quantity += 1;
                                    t.TotalPrice += curTopping.TotalPrice;
                                    added = true;
                                }
                            }
                        }
                    }
                }
                //else if orderToAdd has no toppings
                else
                {
                    foreach (var keyValuePair in existedOrders)
                    {
                        //When current order also has no topping, increase that order's quantity
                        if (!orderedToppings.ContainsKey(keyValuePair.Key))
                        {
                            keyValuePair.Value.Quantity += orderToAdd.Quantity;
                            keyValuePair.Value.TotalPrice += orderToAdd.TotalPrice;
                            added = true;
                        }
                    }
                    //If no orderhas been added (no matched order), then add a new one
                }
            }

            //if no order has been added (no matched orders), then add a completely new one
            if (!added)
            {
                int newKey = 1;
                if (orderedProducts.Count > 0)
                {
                    //Get the latest key
                    int lastKey = orderedProducts.OrderByDescending(o => o.Key).Select(o => o.Key).FirstOrDefault();
                    newKey = lastKey + 1;
                }
                orderedProducts.Add(newKey, orderToAdd);

                //if orderToAdd has toppings
                if (toppingToAdd.Count > 0)
                {
                    orderedToppings.Add(newKey, toppingToAdd);
                }
            }

            LoadOrder();
        }

        private bool isSameTopping(List<OrderDetail> list1, List<OrderDetail> list2)
        {
            // Create sets of ProductIds for efficient lookup
            var set1 = new HashSet<int>(list1.Select(product => product.ProductId));
            var set2 = new HashSet<int>(list2.Select(product => product.ProductId));

            // Check if all ProductIds in list1 exist in set2 and vice versa
            return set1.SetEquals(set2);
        }


        private void LoadOrder()
        {
            totalBill = 0;
            toppingControls.Clear();

            if (pnlOrder.Controls.Count > 0)
            {
                pnlOrder.Controls.Clear();
            }

            if (orderedProducts.Count > 0)
            {
                int countProduct = 0;
                int countTop = 0;
                foreach (var o in orderedProducts)
                {
                    //Order Item
                    OrderItem orderItem = new OrderItem();
                    orderItem.Name = $"Order{o.Key}";
                    orderItem.Location = new Point(0, (countProduct * 56) + countTop * 52);
                    orderItem.ProductId = o.Value.ProductId;
                    orderItem.PropName = o.Value.Product.ProductName;
                    orderItem.PropQuantity = o.Value.Quantity;
                    orderItem.PropUnitPrice = o.Value.Product.Price;
                    orderItem.PropOrderNumber = countProduct + 1;
                    pnlOrder.Controls.Add(orderItem);

                    //Order Delete buttons
                    Button btnDelete = new Button();
                    btnDelete.Name = $"btnDelete{o.Key}";
                    btnDelete.Location = new Point(611, (countProduct * 56) + (countTop * 52) + 11);
                    btnDelete.Size = new Size(36, 27);
                    btnDelete.Text = "X";
                    btnDelete.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    btnDelete.ForeColor = SystemColors.ControlLightLight;
                    btnDelete.BackColor = Color.IndianRed;
                    btnDelete.Click += btnOrderDelete_Click;
                    pnlOrder.Controls.Add(btnDelete);

                    countProduct++;

                    //Topping Item
                    if (orderedToppings.ContainsKey(o.Key))
                    {
                        List<OrderTopping> controls = new List<OrderTopping>();
                        List<OrderDetail> toppingList = orderedToppings[o.Key];
                        foreach (OrderDetail top in toppingList)
                        {
                            OrderTopping toppingItem = new OrderTopping();
                            toppingItem.ToppingFor = o.Key;
                            toppingItem.Location = new Point(0, (countProduct * 56) + countTop * 52);
                            toppingItem.ProductId = top.ProductId;
                            toppingItem.PropName = top.Product.ProductName;
                            toppingItem.PropPrice = top.Product.Price;
                            toppingItem.PropQuantity = top.Quantity;
                            pnlOrder.Controls.Add(toppingItem);
                            //Add into List for further edits

                            controls.Add(toppingItem);

                            countTop++;
                            totalBill += top.TotalPrice;
                        }
                        //Store OrderTopping controls
                        toppingControls.Add(o.Key, controls);
                    }

                    //TotalBill and events
                    orderItem.QuantityChanged += OrderItem_QuantityChanged;
                    totalBill += o.Value.TotalPrice;
                }
            }
            SetLblTotalBill();
        }

        private void btnOrderDelete_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonName = button.Name;
                string[] parts = buttonName.Split(new string[] { "btnDelete" }, StringSplitOptions.None);

                if (parts.Length >= 2 && int.TryParse(parts[1], out int keyToRemove))
                {
                    if (orderedProducts.ContainsKey(keyToRemove))
                    {
                        orderedProducts.Remove(keyToRemove);
                        //RemoveToppings
                        if (orderedToppings.ContainsKey(keyToRemove))
                        {
                            orderedToppings.Remove(keyToRemove);
                        }
                    }
                }
                LoadOrder();
            }
        }

        private void OrderItem_QuantityChanged(object sender, EventArgs e)
        {
            if (sender is OrderItem orderItem)
            {
                double newTotalBill = 0;
                string name = orderItem.Name;
                string[] parts = name.Split(new string[] { "Order" }, StringSplitOptions.None);
                if (parts.Length >= 2 && int.TryParse(parts[1], out int keyOfChange))
                {
                    //Retrieve the product from orderedProduct list
                    var changedProduct = orderedProducts.SingleOrDefault(o => o.Key == keyOfChange);
                    int oldQuantity = changedProduct.Value.Quantity; // Get the old quantity before it changes
                    int newQuantity = orderItem.PropQuantity; // Get the new quantity after the change

                    newTotalBill = (newQuantity - oldQuantity) * changedProduct.Value.Product.Price;

                    //Set the new quantity and totalPrice into order
                    changedProduct.Value.Quantity = newQuantity;
                    changedProduct.Value.TotalPrice = newQuantity * changedProduct.Value.Product.Price;

                    //Change the toppings
                    if (orderedToppings.ContainsKey(keyOfChange))
                    {
                        List<OrderDetail> toppings = orderedToppings[keyOfChange];
                        foreach (OrderDetail top in toppings)
                        {
                            top.Quantity = newQuantity;
                            top.TotalPrice = newQuantity * top.Product.Price;
                            newTotalBill += (newQuantity - oldQuantity) * top.Product.Price;
                        }
                        //Change the control's quantity property
                        if (toppingControls.ContainsKey(keyOfChange))
                        {
                            List<OrderTopping> controls = toppingControls[keyOfChange];
                            foreach (OrderTopping c in controls)
                            {
                                c.PropQuantity = newQuantity;
                            }
                        }
                    }
                    //Update TotalBill
                    totalBill += newTotalBill;
                    SetLblTotalBill();
                    //UpdateTotalBill(changedOrder.PropUnitPrice, oldQuantity, newQuantity);
                }
            }
        }

        private void SetLblTotalBill()
        {
            lblTotalBill.Text = formatter.VNmoney(totalBill); // Format as currency
        }

        //private void UpdateTotalBill(double price, int oldQuantity, int newQuantity)
        //{
        //    totalBill += (newQuantity - oldQuantity) * price;
        //    SetLblTotalBill();
        //}

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            printPreviewDialogBill.Document = printDocumentBill;
            printDocumentBill.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprmm", 280, 600);
            printPreviewDialogBill.ShowDialog();
        }

        private void AddOrderIntoDB()
        {
            if (orderedProducts.Count > 0)
            {
                //Insert into Order table
                try
                {
                    Order newOrder = new Order
                    {
                        Total = totalBill,
                        DateCreated = DateTime.Now,
                        BranchId = acc.BranchId,
                    };
                    db.Orders.Add(newOrder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occured when adding new order: {ex.Message}");
                }

                //If order added successfully
                if (db.SaveChanges() > 0)
                {
                    //Retrieve the latest orderID
                    var latestOrder = db.Orders.OrderByDescending(o => o.OrderId).Select(o => o.OrderId).FirstOrDefault();

                    if (latestOrder != null)
                    {
                        //Insert into OrderDetail table
                        foreach (var o in orderedProducts)
                        {
                            try
                            {
                                var productToAdd = new OrderDetail
                                {
                                    OrderId = latestOrder,
                                    ProductId = o.Value.ProductId,
                                    Quantity = o.Value.Quantity,
                                    TotalPrice = o.Value.TotalPrice,
                                };
                                db.OrderDetails.Add(productToAdd);

                                if (orderedToppings.ContainsKey(o.Key))
                                {
                                    List<OrderDetail> toppingList = orderedToppings[o.Key];
                                    foreach (OrderDetail top in toppingList)
                                    {
                                        top.OrderId = latestOrder;
                                        var toppingToAdd = new OrderDetail
                                        {
                                            OrderId = latestOrder,
                                            ProductId = top.ProductId,
                                            Quantity = top.Quantity,
                                            TotalPrice = top.TotalPrice,
                                        };
                                        db.OrderDetails.Add(toppingToAdd);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occured when adding new OrderDetail: {ex.Message}");
                            }

                        }
                    }
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Order added successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }

            }
            else
            {
                MessageBox.Show("Please choose at least 1 product!");
            }
        }

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var branch = acc.Branch;

            string seperator = "-----------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString("MILK TEA STORE", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 10, 20);
            e.Graphics.DrawString($"Address: {branch.Address}", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, 40);
            e.Graphics.DrawString($"Phone: {branch.Phone}", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, 50);
            e.Graphics.DrawString("Time: " + DateTime.Now, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, 60);

            // ----------------------------------------------------------------------------------------------------
            e.Graphics.DrawString(seperator, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, 80);

            // Get the height of the generated bill section
            string generatedBill = generateBill();
            SizeF generatedBillSize = e.Graphics.MeasureString(generatedBill, new Font("Arial", 5, FontStyle.Regular));

            // Draw the generated bill section
            e.Graphics.DrawString(generatedBill, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, 90);
            // Calculate the y-coordinate for the second separator
            int secondSeparatorY = 90 + (int)generatedBillSize.Height + 10;

            //-------------------------------------------------------------------------------------------------------
            e.Graphics.DrawString(seperator, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, secondSeparatorY);

            // Calculate the y-coordinate for the totalBill line
            int totalBillY = secondSeparatorY + 10;
            // Format the totalBill string
            string strTotalBill = string.Format("{0,-75}{1,-10}", "TOTAL: ", formatter.VNmoney(totalBill));
            // Draw the totalBill line
            e.Graphics.DrawString(strTotalBill, new Font("Arial", 5, FontStyle.Bold), Brushes.Black, 10, totalBillY);

            // Calculate the y-coordinate for the third separator
            int thirdSeparatorY = totalBillY + 10;

            //-------------------------------------------------------------------------------------------------------
            e.Graphics.DrawString(seperator, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, 10, thirdSeparatorY);

            // Calculate the y-coordinate for the "THANK YOU" line
            int thankYouY = thirdSeparatorY + 10;

            // Draw the "THANK YOU" line
            e.Graphics.DrawString("THANK YOU FOR YOUR PURCHASE!", new Font("Arial", 5, FontStyle.Bold), Brushes.Black, 10, thankYouY);

        }

        private string? generateBill()
        {
            MoneyFormatter formatter = new MoneyFormatter();
            StringBuilder strBill = new StringBuilder();
            strBill.Append(string.Format("{0,-40}{1,-30}{2,-20}{3,-30}\n", "Product", "UnitPrice", "Quantity", "Total"));
            if (orderedProducts.Count > 0)
            {
                foreach (var o in orderedProducts)
                {
                    strBill.Append(string.Format("{0,-40}{1,-30}{2,-20}{3,-30}\n", o.Value.Product.ProductName, formatter.VNmoney(o.Value.Product.Price), $"x{o.Value.Quantity.ToString()}", formatter.VNmoney(o.Value.TotalPrice)));
                    if (orderedToppings.ContainsKey(o.Key))
                    {
                        List<OrderDetail> toppingList = orderedToppings[o.Key];
                        foreach (OrderDetail top in toppingList)
                        {
                            strBill.Append(string.Format("{0,-40}{1,-30}{2,-20}{3,-30}\n", $"+ {top.Product.ProductName}", formatter.VNmoney(top.Product.Price), $"x{top.Quantity.ToString()}", $"+{formatter.VNmoney(top.TotalPrice)}"));
                        }
                    }
                }
            }
            return strBill.ToString();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var catIdList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).Select(c => c.CategoryId).ToArray();
            LoadMenu(catIdList);
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            AddOrderIntoDB();
            orderedProducts.Clear();
            orderedToppings.Clear();
            LoadOrder();
            var catIdList = db.Categories.Where(c => !c.CategoryName.Equals("Topping")).Select(c => c.CategoryId).ToArray();
            LoadMenu(catIdList);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
