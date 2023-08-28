namespace MilkTea.Controls
{
    partial class OrderItem
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
            lblNumber = new Label();
            lblName = new Label();
            lblTotalPrice = new Label();
            lblUnitPrice = new Label();
            numQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(3, 7);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(24, 20);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "#1";
            // 
            // lblName
            // 
            lblName.Location = new Point(34, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(256, 41);
            lblName.TabIndex = 1;
            lblName.Text = "Trà sữa thường";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.ForeColor = Color.DarkGoldenrod;
            lblTotalPrice.Location = new Point(493, 7);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(86, 20);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "30.000VNĐ";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(297, 7);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(86, 20);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "30.000VNĐ";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(416, 4);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(50, 27);
            numQuantity.TabIndex = 4;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblName);
            Controls.Add(lblNumber);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderItem";
            Size = new Size(602, 48);
            Load += OrderItem_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Label lblName;
        private Label lblTotalPrice;
        private Label lblUnitPrice;
        private NumericUpDown numQuantity;
    }
}
