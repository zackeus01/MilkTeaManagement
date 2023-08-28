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
    public partial class OrderTopping : UserControl
    {
        public OrderTopping()
        {
            InitializeComponent();
        }

        private MoneyFormatter formatter = new MoneyFormatter();
        #region Properties
        private int _id;
        private int _topFor;
        private string _name;
        private double _price;
        private int _quantity;
        private double _totalPrice;

        public int ProductId
        {
            get { return _id; }
            set { _id = value; }
        }

        public int ToppingFor
        {
            get { return _topFor; }
            set { _topFor = value; }
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
        public int PropQuantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                if (value != null)
                {
                    lblQuantity.Text = $"x {value}";
                    setTotalPrice();
                }
                else
                {
                    lblQuantity.Text = "Unknown Price";
                }
            }
        }

        [Category("Custom Props")]
        public double PropPrice
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

        public double setTotalPrice()
        {
            double totalPrice = _quantity * _price;
            lblTotalPrice.Text = formatter.VNmoney(totalPrice);
            return totalPrice;
        }

        #endregion
    }
}
