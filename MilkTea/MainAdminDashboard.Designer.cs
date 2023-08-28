namespace MilkTea
{
    partial class MainAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminDashboard));
            panel1 = new Panel();
            btnBranch = new Button();
            btnEmployee = new Button();
            btnManager = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnBranch);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnManager);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 899);
            panel1.TabIndex = 0;
            // 
            // btnBranch
            // 
            btnBranch.BackColor = Color.White;
            btnBranch.Location = new Point(30, 202);
            btnBranch.Name = "btnBranch";
            btnBranch.Size = new Size(110, 61);
            btnBranch.TabIndex = 2;
            btnBranch.Text = "Branches";
            btnBranch.UseVisualStyleBackColor = false;
            btnBranch.Click += btnBranch_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.White;
            btnEmployee.Location = new Point(30, 433);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(110, 64);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Employees";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnManager
            // 
            btnManager.BackColor = Color.White;
            btnManager.Location = new Point(30, 315);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(110, 60);
            btnManager.TabIndex = 4;
            btnManager.Text = "Managers";
            btnManager.UseVisualStyleBackColor = false;
            btnManager.Click += btnManager_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.Location = new Point(30, 94);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(110, 59);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1928, 138);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1557, 66);
            label2.Name = "label2";
            label2.Size = new Size(191, 31);
            label2.TabIndex = 4;
            label2.Text = "Welcome Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 48);
            label1.Name = "label1";
            label1.Size = new Size(458, 60);
            label1.TabIndex = 3;
            label1.Text = "MilkTea Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Info;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(1771, 55);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(195, 144);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1733, 899);
            mainPanel.TabIndex = 3;
            // 
            // MainAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainAdminDashboard";
            Text = "MainAdminDashboard";
            WindowState = FormWindowState.Maximized;
            Load += MainAdminManagement_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnManager;
        private Button btnHome;
        private Panel panel2;
        private Button btnEmployee;
        private Button btnBranch;
        private Panel mainPanel;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}