namespace MilkTea.Controls
{
    partial class MenuItem
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
            lblPrice = new Label();
            lblName = new Label();
            picImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.DarkGoldenrod;
            lblPrice.Location = new Point(3, 232);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(169, 27);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(3, 175);
            lblName.Name = "lblName";
            lblName.Size = new Size(169, 53);
            lblName.TabIndex = 4;
            lblName.Text = "Initial Text";
            // 
            // picImage
            // 
            picImage.Location = new Point(3, 3);
            picImage.Name = "picImage";
            picImage.Size = new Size(169, 169);
            picImage.TabIndex = 3;
            picImage.TabStop = false;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(picImage);
            Name = "MenuItem";
            Size = new Size(175, 267);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPrice;
        private Label lblName;
        private PictureBox picImage;
    }
}
