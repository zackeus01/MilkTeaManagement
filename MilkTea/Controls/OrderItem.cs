using MilkTea.Formatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea.Controls
{
    public partial class OrderItem : UserControl
    {
        public OrderItem()
        {
            InitializeComponent();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            _quantity = (int)numQuantity.Value;
            setTotalPrice();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private MoneyFormatter formatter = new MoneyFormatter();
        #region Properties
        private int _id;
        private int _number;
        private string _name;
        private int _quantity;
        private double _price;
        public event EventHandler QuantityChanged;

        public int ProductId
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public int PropOrderNumber
        {
            get { return _number; }
            set
            {
                _number = value;
                if (value != null)
                {
                    lblNumber.Text = $"#{value.ToString()}";
                }
                else
                {
                    lblNumber.Text = "Unknown";
                }
            }
        }

        [Category("Custom Props")]
        public String PropName
        {
            get { return _name; }
            set
            {
                _name = value;
                if (value != null)
                {
                    lblName.Text = value.ToUpper();
                }
                else
                {
                    lblName.Text = "Unknown Item";
                }
            }
        }

        [Category("Custom Props")]
        public double PropUnitPrice
        {
            get { return _price; }
            set
            {
                _price = value;
                if (value != null)
                {
                    lblUnitPrice.Text = formatter.VNmoney(value);
                }
                else
                {
                    lblUnitPrice.Text = "Unknown Price";
                }
            }
        }

        [Category("Custom Props")]
        public int PropQuantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                if (value != null)
                {
                    numQuantity.Value = value;
                }
                else
                {
                    numQuantity.Value = 1;
                }
            }
        }

        public double setTotalPrice()
        {
            double totalPrice = _quantity * _price;
            lblTotalPrice.Text = formatter.VNmoney(totalPrice);
            return totalPrice;
        }

        #endregion

        private void OrderItem_Load(object sender, EventArgs e)
        {
            setTotalPrice();
        }
    }
}
