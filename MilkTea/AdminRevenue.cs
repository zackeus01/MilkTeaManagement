using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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
    public partial class AdminRevenue : Form
    {
        Account acc;

        public AdminRevenue()
        {
            InitializeComponent();
        }
        public AdminRevenue(Account ac)
        {
            InitializeComponent();
            acc = ac;
        }


        private void AdminRevenue_Load(object sender, EventArgs e)
        {
            LoadBranchName();
            dgvAminRevenueOrder.ColumnHeaderMouseClick += dgvAminRevenueOrder_ColumnHeaderMouseClick;
            txtTotalOfOrders.ReadOnly = true;
            txtBranchRevenue.ReadOnly = true;
            txtTotal.ReadOnly = true;
            //txtBranchName.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;
            TotalOfOrdersAndRevenue();
            LoadOrder();
        }

        private void LoadBranchName()
        {
            using (var db = new MilkteaDBContext())
            {
                var adminRevenueOrderList = db.Accounts
                    .Where(a => a.AccountId == acc.AccountId)
                    .Select(a => a.BranchId)
                    .FirstOrDefault();

                if (adminRevenueOrderList != null)
                {
                    var branchName = db.Branches
                        .Where(b => b.BranchId == adminRevenueOrderList)
                        .Select(b => b.BranchName)
                        .FirstOrDefault();

                    lbBranchName.Text = branchName;
                    lbRevenue.Text = "REVENUE OF";
                }
            }
        }

        private void LoadOrder()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrder.AutoGenerateColumns = false;
                dgvAminRevenueOrder.Columns.Clear();
                dgvAminRevenueOrder.DataSource = null;

                var adminRevenueOrderList = db.Orders
                    .Where(odlist => odlist.BranchId == db.Accounts
                        .Where(a => a.AccountId == acc.AccountId)
                        .Select(a => a.BranchId)
                        .FirstOrDefault())
                    .Select(odlist => new
                    {
                        OrderId = odlist.OrderId,
                        Total = odlist.Total,
                        DateCreated = odlist.DateCreated,

                        BranchName = db.Branches
                            .Where(b => b.BranchId == odlist.BranchId)
                            .Select(b => b.BranchName)
                            .FirstOrDefault(),

                        TottalOrder = db.Orders.Sum(o => o.Total),
                        TotalPriceSum = db.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice)
                    })
                    .ToList();

                dgvAminRevenueOrder.DataSource = adminRevenueOrderList;

                // tổ chức các cột cho datagrid view theo yêu cầu bài toán 
                DataGridViewTextBoxColumn total = new DataGridViewTextBoxColumn();
                total.Name = "Total";
                total.HeaderText = "Total per Order";
                total.DataPropertyName = "Total";

                DataGridViewTextBoxColumn dateCreated = new DataGridViewTextBoxColumn();
                dateCreated.Name = "DateCreated";
                dateCreated.HeaderText = "Date Created";
                dateCreated.DataPropertyName = "DateCreated";

                DataGridViewTextBoxColumn orderId = new DataGridViewTextBoxColumn();
                orderId.Name = "OrderId";
                orderId.HeaderText = "Order Id";
                orderId.DataPropertyName = "OrderId";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAminRevenueOrder.Columns.Add(orderId);
                dgvAminRevenueOrder.Columns.Add(total);
                dgvAminRevenueOrder.Columns.Add(dateCreated);
                dgvAminRevenueOrder.Columns["OrderId"].Visible = true;
            }
        }

        private void dgvAminRevenueOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrder.Rows.Count && e.ColumnIndex >= 0)
            {
                var total = dgvAminRevenueOrder.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                var dateCreated = dgvAminRevenueOrder.Rows[e.RowIndex].Cells["DateCreated"].Value.ToString();

                // binding du lieu 
                txtTotal.Text = total;
                dtDateCreated.Value = DateTime.Parse(dateCreated); // Parse string to DateTime
            }

            // hiển thị lên dgvAminRevenueOrderDetail
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrder.Rows.Count && e.ColumnIndex >= 0)
            {
                var orderId = Convert.ToInt32(dgvAminRevenueOrder.Rows[e.RowIndex].Cells["OrderId"].Value);
                DisplayOrderDetails(orderId);
            }
        }

        // display thông tin lên dgvOrrderDetail
        private void DisplayOrderDetails(int orderId)
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrderDetail.AutoGenerateColumns = false;
                dgvAminRevenueOrderDetail.Columns.Clear();
                dgvAminRevenueOrderDetail.DataSource = null;

                // total quantities of 1 orderdetail
                var totalOFQuantities = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Quantity);
                // total of prices of 1 orderdetail
                var totalOFPrices = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.TotalPrice);

                var orderDetails = db.OrderDetails
                    .Where(od => od.OrderId == orderId)
                    .Select(od => new
                    {
                        OrderDetailId = od.OrderDetailId,
                        ProductId = od.ProductId,
                        Quantity = od.Quantity,
                        TotalOfQuantities = totalOFQuantities,
                        TotalPrice = od.TotalPrice,
                        TotalOfPrices = totalOFPrices,
                        ProductName = db.Products
                            .Where(p => p.ProductId == od.ProductId)
                            .Select(p => p.ProductName)
                            .FirstOrDefault()
                    })
                    .ToList();

                dgvAminRevenueOrderDetail.DataSource = orderDetails;

                // Tạo các cột cho DataGridView dgvAminRevenueOrderDetail
                DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                productNameColumn.Name = "ProductName";
                productNameColumn.HeaderText = "Product Name";
                productNameColumn.DataPropertyName = "ProductName";

                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.Name = "Quantity";
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.DataPropertyName = "Quantity";

                DataGridViewTextBoxColumn totalOfQuantities = new DataGridViewTextBoxColumn();
                totalOfQuantities.Name = "TotalOfQuantities";
                totalOfQuantities.HeaderText = "Total Of Quantities";
                totalOfQuantities.DataPropertyName = "TotalOfQuantities";

                DataGridViewTextBoxColumn totalPrice = new DataGridViewTextBoxColumn();
                totalPrice.Name = "TotalPrice";
                totalPrice.HeaderText = "Total Price";
                totalPrice.DataPropertyName = "TotalPrice";

                DataGridViewTextBoxColumn totalOfPrices = new DataGridViewTextBoxColumn();
                totalOfPrices.Name = "TotalOfPrices";
                totalOfPrices.HeaderText = "Total Of Prices";
                totalOfPrices.DataPropertyName = "TotalOfPrices";

                DataGridViewTextBoxColumn orderDetailId = new DataGridViewTextBoxColumn();
                orderDetailId.Name = "OrderDetailId";
                orderDetailId.HeaderText = "OrderDetail Id";
                orderDetailId.DataPropertyName = "OrderDetailId";

                // Thêm các cột vào DataGridView dgvAminRevenueOrderDetail
                dgvAminRevenueOrderDetail.Columns.Add(orderDetailId);
                dgvAminRevenueOrderDetail.Columns.Add(productNameColumn);
                dgvAminRevenueOrderDetail.Columns.Add(quantityColumn);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfQuantities);
                dgvAminRevenueOrderDetail.Columns.Add(totalPrice);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfPrices);
                dgvAminRevenueOrderDetail.Columns["TotalOfQuantities"].Visible = false;
                dgvAminRevenueOrderDetail.Columns["TotalOfPrices"].Visible = false;
            }
        }

        private void dgvAminRevenueOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAminRevenueOrderDetail.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAminRevenueOrderDetail.Rows[e.RowIndex];

                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                var quantity = selectedRow.Cells["Quantity"].Value.ToString();
                var totalPrice = selectedRow.Cells["TotalPrice"].Value.ToString();
                var totalOfQuantities = selectedRow.Cells["TotalOfQuantities"].Value.ToString();
                var totalOfPrices = selectedRow.Cells["TotalOfPrices"].Value.ToString();

                // Gán thông tin vào các TextBox tương ứng
                txtProductName.Text = productName;
                txtQuantity.Text = quantity;
                txttotalQuantities.Text = totalOfQuantities;
                txtTotalPrice.Text = totalPrice;
                txtTotalPrices.Text = totalOfPrices;
            }
        }

        // Total of Orders
        private void TotalOfOrdersAndRevenue()
        {
            using (var db = new MilkteaDBContext())
            {
                //var accountId = 1;

                var totalOfOrders = db.Orders
                    .Where(o => o.BranchId == db.Accounts
                        //.Where(a => a.AccountId == accountId)
                        .Select(a => a.BranchId)
                        .FirstOrDefault())
                    .Sum(o => o.Total);

                txtTotalOfOrders.Text = totalOfOrders.ToString();

                var revenue = db.OrderDetails
                    .Where(od => od.Order.BranchId == db.Branches
                        .Where(b => b.BranchId == db.Accounts
                            //.Where(a => a.AccountId == accountId)
                            .Select(a => a.BranchId)
                            .FirstOrDefault())
                        .Select(b => b.BranchId)
                        .FirstOrDefault())
                    .Sum(od => od.TotalPrice);

                txtBranchRevenue.Text = revenue.ToString();
            }
        }

        // search - defect 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Must not be Empty.");
                return;
            }

            if (dgvAminRevenueOrder.SelectedRows.Count > 0)
            {
                var orderId = Convert.ToInt32(dgvAminRevenueOrder.SelectedRows[0].Cells["OrderId"].Value);
                LoadSearch(orderId, txtSearch.Text.Trim());
            }
        }

        private void LoadSearch(int orderId, string searchKeyword)
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAminRevenueOrderDetail.AutoGenerateColumns = false;
                dgvAminRevenueOrderDetail.Columns.Clear();
                dgvAminRevenueOrderDetail.DataSource = null;

                var totalOFQuantities = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Quantity);
                var totalOFPrices = db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.TotalPrice);

                var orderDetails = db.OrderDetails
                    .Where(od => od.OrderId == orderId && od.Product.ProductName.Contains(searchKeyword))
                    .Select(od => new
                    {
                        ProductId = od.ProductId,
                        Quantity = od.Quantity,
                        TotalOfQuantities = totalOFQuantities,
                        TotalPrice = od.TotalPrice,
                        TotalOfPrices = totalOFPrices,
                        ProductName = od.Product.ProductName
                    })
                    .ToList();

                dgvAminRevenueOrderDetail.DataSource = orderDetails;

                DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                productNameColumn.Name = "ProductName";
                productNameColumn.HeaderText = "Product Name";
                productNameColumn.DataPropertyName = "ProductName";

                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.Name = "Quantity";
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.DataPropertyName = "Quantity";

                DataGridViewTextBoxColumn totalOfQuantities = new DataGridViewTextBoxColumn();
                totalOfQuantities.Name = "TotalOfQuantities";
                totalOfQuantities.HeaderText = "Total Of Quantities";
                totalOfQuantities.DataPropertyName = "TotalOfQuantities";

                DataGridViewTextBoxColumn totalPrice = new DataGridViewTextBoxColumn();
                totalPrice.Name = "TotalPrice";
                totalPrice.HeaderText = "Total Price";
                totalPrice.DataPropertyName = "TotalPrice";

                DataGridViewTextBoxColumn totalOfPrices = new DataGridViewTextBoxColumn();
                totalOfPrices.Name = "TotalOfPrices";
                totalOfPrices.HeaderText = "Total Of Prices";
                totalOfPrices.DataPropertyName = "TotalOfPrices";

                dgvAminRevenueOrderDetail.Columns.Add(productNameColumn);
                dgvAminRevenueOrderDetail.Columns.Add(quantityColumn);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfQuantities);
                dgvAminRevenueOrderDetail.Columns.Add(totalPrice);
                dgvAminRevenueOrderDetail.Columns.Add(totalOfPrices);
                dgvAminRevenueOrderDetail.Columns["TotalOfQuantities"].Visible = false;
                dgvAminRevenueOrderDetail.Columns["TotalOfPrices"].Visible = false;
            }
        }

        // khai báo 1 biến hiện tại
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        private bool doubleClick = false;

        // sort click title cho order -> defect 
        private async void dgvAminRevenueOrder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvAminRevenueOrder.Columns[e.ColumnIndex];

            // Kiểm tra xem có đúp chuột hay không
            if (doubleClick)
            {
                // Đảo ngược hướng sắp xếp khi đúp chuột
                currentSortDirection = (currentSortDirection == ListSortDirection.Ascending)
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
            else
            {
                SortData(clickedColumn);
            }

            // Đặt biến doubleClick thành true để đánh dấu lần nhấp chuột
            doubleClick = true;

            // Đợi 300ms để kiểm tra xem có phải đúp chuột hay không
            await Task.Delay(300);

            // Đặt biến doubleClick thành false sau khi đợi
            doubleClick = false;
        }

        private void SortData(DataGridViewColumn column)
        {
            string propertyName = column.DataPropertyName;

            using (var db = new MilkteaDBContext())
            {

                List<Order> orderToDisplay = db.Orders.ToList(); // thonng tin cac Order

                if (currentSortDirection == ListSortDirection.Ascending)
                {
                    orderToDisplay = orderToDisplay.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    orderToDisplay = orderToDisplay.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
                dgvAminRevenueOrder.DataSource = orderToDisplay;
            }
        }

        // trích xuất giá trị của một thuộc tính cụ thể từ một đối tượng bằng cách sử dụng reflection
        // reflection: tạo đối tượng, gọi phương thức
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        private void dgvAminRevenueOrderDetail_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void SortDataOD(DataGridViewColumn column)
        {
        }

        // filter by date 
        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var fromDate = dtFrom.Value.Date;
                var toDate = dtTo.Value.Date.AddDays(1).AddTicks(-1); // Include the entire selected day

                var filteredOrders = db.Orders
                    .Where(o => o.DateCreated >= fromDate && o.DateCreated <= toDate)
                    .ToList();

                dgvAminRevenueOrder.DataSource = filteredOrders;
            }
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            LoadOrder();
        }

        // paging 
        private int currentPage = 1;
        private int itemsPerPage = 10; // số lượng mỗi trang

        private void LoadOrder(int page)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalOrders = db.Orders.Count();
                var totalPages = (int)Math.Ceiling((double)totalOrders / itemsPerPage);

                if (page < 1)
                    page = 1;
                if (page > totalPages)
                    page = totalPages;

                currentPage = page;

                var ordersToDisplay = db.Orders
                    .OrderBy(b => b.OrderId)
                    .Skip((currentPage - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .Select(o => new
                    {
                        o.OrderId,
                        o.Total,
                        o.DateCreated
                    })
                    .ToList();

                dgvAminRevenueOrder.DataSource = ordersToDisplay;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadOrder(1);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            LoadOrder(currentPage - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadOrder(currentPage + 1);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalOrder = db.Orders.Count();
                var totalPages = (int)Math.Ceiling((double)totalOrder / itemsPerPage);

                LoadOrder(totalPages);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Excel workbook
            var workbook = new XLWorkbook();

            // Add a worksheet to the workbook
            var worksheet = workbook.Worksheets.Add("Data");

            // Set the column headers
            worksheet.Cell(1, 1).Value = "Order Detail";
            worksheet.Cell(1, 2).Value = "Order";
            worksheet.Cell(1, 3).Value = "Product Name";
            worksheet.Cell(1, 4).Value = "Quantity";
            worksheet.Cell(1, 5).Value = "Date Created";
            worksheet.Cell(1, 6).Value = "Branch";
            worksheet.Cell(1, 7).Value = "Total Price";

            // Get the data from the database
            using (var db = new MilkteaDBContext())
            {
                var orders = db.OrderDetails.Include(e => e.Order).Include(e => e.Product).Include(e => e.Order.Branch).ToList();

                // Populate the worksheet with the data
                for (int i = 0; i < orders.Count; i++)
                {
                    var order = orders[i];
                    worksheet.Cell(i + 2, 1).Value = order.OrderDetailId;
                    worksheet.Cell(i + 2, 2).Value = order.OrderId;
                    worksheet.Cell(i + 2, 3).Value = order.Product.ProductName;
                    worksheet.Cell(i + 2, 4).Value = order.Quantity;
                    worksheet.Cell(i + 2, 5).Value = order.Order.DateCreated.Value.ToString("dd/MM/yyyy");
                    worksheet.Cell(i + 2, 6).Value = order.Order.Branch.BranchName;
                    worksheet.Cell(i + 2, 7).Value = order.TotalPrice;
                }

                var branchCounts = orders.GroupBy(o => o.Order.Branch.BranchName)
                              .Select(g => new
                              {
                                  BranchName = g.Key,
                                  TotalOrders = g.Sum(o => o.Order.Total),
                                  TotalIncome = g.Sum(o => o.TotalPrice)
                              })
                              .ToList();
                var totalOrders = orders.GroupBy(o => o.OrderId).Select(t => new
                {
                    AllOrders = t.Sum(o => o.Order.Total)
                }).ToList();

                int lastRow = orders.Count + 1;
                worksheet.Cell(lastRow + 2, 1).Value = "Total Orders";
                worksheet.Cell(lastRow + 2, 2).Value = totalOrders.Sum(t => t.AllOrders);

                worksheet.Cell(lastRow + 3, 1).Value = "Total Income";
                worksheet.Cell(lastRow + 3, 2).FormulaA1 = $"SUM(G2:G{lastRow})";

                int branchRow = lastRow + 5;
                worksheet.Cell(branchRow, 1).Value = "Branch";
                worksheet.Cell(branchRow, 2).Value = "Total Orders";
                worksheet.Cell(branchRow, 3).Value = "Total Income";

                for (int i = 0; i < branchCounts.Count; i++)
                {
                    var branchCount = branchCounts[i];
                    worksheet.Cell(branchRow + i + 1, 1).Value = branchCount.BranchName;
                    worksheet.Cell(branchRow + i + 1, 2).Value = branchCount.TotalOrders;
                    worksheet.Cell(branchRow + i + 1, 3).Value = branchCount.TotalIncome;
                }
                // Save the workbook to a file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Data saved to Excel file successfully.");
                }
            }
        }
    }
    // cách 2 để show
    //dgvAminRevenueOrderDetail.Columns.AddRange(
    //                    productNameColumn, quantityColumn, totalOfQuantitiesColumn,
    //                    totalPriceColumn, totalOfPricesColumn
    //                );
}