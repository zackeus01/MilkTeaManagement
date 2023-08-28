namespace MilkTea
{
    partial class MainAdminHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminHome));
            lbTotalManager = new Label();
            lbTotalEmployee = new Label();
            lbTotalBranch = new Label();
            lbTotalRevenue = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbTotalManager
            // 
            lbTotalManager.AutoSize = true;
            lbTotalManager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalManager.Location = new Point(18, 50);
            lbTotalManager.Name = "lbTotalManager";
            lbTotalManager.Size = new Size(229, 28);
            lbTotalManager.TabIndex = 1;
            lbTotalManager.Text = "Show tổng số manager";
            // 
            // lbTotalEmployee
            // 
            lbTotalEmployee.AutoSize = true;
            lbTotalEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalEmployee.Location = new Point(32, 50);
            lbTotalEmployee.Name = "lbTotalEmployee";
            lbTotalEmployee.Size = new Size(182, 28);
            lbTotalEmployee.TabIndex = 2;
            lbTotalEmployee.Text = "tổng số nhân viên";
            // 
            // lbTotalBranch
            // 
            lbTotalBranch.AutoSize = true;
            lbTotalBranch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalBranch.Location = new Point(39, 42);
            lbTotalBranch.Name = "lbTotalBranch";
            lbTotalBranch.Size = new Size(182, 28);
            lbTotalBranch.TabIndex = 3;
            lbTotalBranch.Text = "tổng số chi nhánh";
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalRevenue.Location = new Point(35, 43);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(186, 28);
            lbTotalRevenue.TabIndex = 4;
            lbTotalRevenue.Text = "tổng số doanh thu";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(lbTotalManager);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(754, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 7);
            label4.Name = "label4";
            label4.Size = new Size(178, 31);
            label4.TabIndex = 12;
            label4.Text = "Total Managers";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(lbTotalEmployee);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1046, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 7);
            label5.Name = "label5";
            label5.Size = new Size(187, 31);
            label5.TabIndex = 13;
            label5.Text = "Total Employees";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(lbTotalBranch);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(111, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 4);
            label2.Name = "label2";
            label2.Size = new Size(170, 31);
            label2.TabIndex = 10;
            label2.Text = "Total Branches";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cornsilk;
            panel4.Controls.Add(lbTotalRevenue);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(429, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 7);
            label3.Name = "label3";
            label3.Size = new Size(163, 31);
            label3.TabIndex = 11;
            label3.Text = "Total Revenue";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 261);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // MainAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1761, 882);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainAdminHome";
            Text = "MainAdminHome";
            Load += MainAdminHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbTotalManager;
        private Label lbTotalEmployee;
        private Label lbTotalBranch;
        private Label lbTotalRevenue;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}