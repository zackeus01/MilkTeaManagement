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
    public partial class ToppingSelect : Form
    {
        private MoneyFormatter formatter = new MoneyFormatter();
        public event Action<OrderDetail, List<OrderDetail>> OrderAdded;

        private Product curProduct;
        MilkteaDBContext db = new MilkteaDBContext();

        public ToppingSelect(Product product)
        {
            curProduct = product;
            InitializeComponent();
        }

        private void frmToppingSelect_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadToppings();
        }

        private void LoadToppings()
        {
            var toppings = db.Products.Where(x => x.Category.CategoryName == "Topping").ToList();
            var toppingList = toppings.Select(x => new
            {
                Id = x.ProductId,
                Name = x.ProductName,
                Price = x.Price,
            }).ToList();
            dgvToppings.DataSource = toppingList;
        }

        private void LoadData()
        {
            if (curProduct.Image != null)
            {
                try
                {
                    picImage.Image = Image.FromFile(curProduct.Image);
                }
                catch (Exception ex)
                {
                    picImage.Image = Image.FromFile("C:\\Users\\Dinh Nguyen\\Pictures\\Milktea\\No-Image-Placeholder.svg.png");
                }
            }

            lblName.Text = curProduct.ProductName;
            string formattedPrice = string.Format("{0:N0} VNĐ", curProduct.Price);
            lblTotalPrice.Text = formattedPrice;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new OrderDetail
            {
                ProductId = curProduct.ProductId,
                Quantity = (int)numQuantity.Value,
                TotalPrice = curProduct.Price * (int)numQuantity.Value,
                Product = curProduct,
            };
            var topping = GetToppings();
            this.Close();
            OrderAdded?.Invoke(order, topping);

        }

        private List<OrderDetail> GetToppings()
        {
            var toppingIds = new List<int>();
            foreach (DataGridViewRow row in dgvToppings.Rows)
            {
                bool selected = bool.Parse(row.Cells["Select"].FormattedValue.ToString());
                //If employee is selected then add to the delete list
                if (selected)
                {
                    toppingIds.Add(int.Parse(row.Cells["Id"].FormattedValue.ToString()));
                }
            }
            var toppings = db.Products.Where(t => toppingIds.Contains(t.ProductId)).ToList();
            var orderedTopping = toppings.Select(t => new OrderDetail
            {
                ProductId = t.ProductId,
                Quantity = (int)numQuantity.Value,
                TotalPrice = t.Price * (int)numQuantity.Value,
                Product = t,
            }).ToList();

            return orderedTopping;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            double totalPrice = (int)numQuantity.Value * curProduct.Price;
            lblTotalPrice.Text = formatter.VNmoney(totalPrice);
        }
    }
}
