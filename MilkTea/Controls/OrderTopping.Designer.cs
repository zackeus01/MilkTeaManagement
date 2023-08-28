namespace MilkTea.Controls
{
    partial class OrderTopping
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblUnitPrice = new Label();
            label1 = new Label();
            lblQuantity = new Label();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(77, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 17);
            lblName.TabIndex = 3;
            lblName.Text = "Trà sữa thường";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.ForeColor = SystemColors.ControlText;
            lblUnitPrice.Location = new Point(297, 13);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(73, 17);
            lblUnitPrice.TabIndex = 4;
            lblUnitPrice.Text = "30.000VNĐ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 7);
            label1.Name = "label1";
            label1.Size = new Size(25, 25);
            label1.TabIndex = 5;
            label1.Text = "+";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(416, 13);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(25, 17);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "x 1";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.ForeColor = Color.OliveDrab;
            lblTotalPrice.Location = new Point(493, 13);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(73, 17);
            lblTotalPrice.TabIndex = 7;
            lblTotalPrice.Text = "30.000VNĐ";
            // 
            // OrderTopping
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(lblTotalPrice);
            Controls.Add(lblQuantity);
            Controls.Add(label1);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "OrderTopping";
            Size = new Size(602, 46);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblUnitPrice;
        private Label label1;
        private Label lblQuantity;
        private Label lblTotalPrice;
    }
}
