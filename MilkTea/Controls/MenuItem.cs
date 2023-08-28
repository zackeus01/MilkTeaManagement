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
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
        }
        private MoneyFormatter formatter = new MoneyFormatter();

        #region Properties
        private int _id;
        private string _name;
        private double _price;
        private Image _image;

        public int ProductId
        {
            get { return _id; }
            set { _id = value; }
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
        public double PropPrice
        {
            get { return _price; }
            set
            {
                _price = value;
                if (value != null)
                {
                    lblPrice.Text = formatter.VNmoney(value);
                }
                else
                {
                    lblPrice.Text = "Unknown Price";
                }
            }
        }

        [Category("Custom Props")]
        public Image PropImage
        {
            get { return _image; }
            set
            {

                _image = value;

                if (value != null)
                {
                    // Create a new bitmap with the desired size (123x172)
                    Bitmap resizedImage = new Bitmap(169, 169);

                    // Create a Graphics object to draw the resized image
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        // Set the interpolation mode to high quality for better resizing
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        // Use PictureBoxSizeMode.Zoom to preserve the aspect ratio and fill the control
                        graphics.DrawImage(value, new Rectangle(0, 0, 169, 169));
                    }

                    // Set the resized image as the Image property of imgCover
                    picImage.Image = resizedImage;
                }
                else
                {
                    // If the value is null, clear the image
                    picImage.Image = null;
                }

            }
        }

        #endregion
    }
}
