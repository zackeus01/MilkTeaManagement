namespace MilkTea
{
    partial class AdminMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            panel1 = new Panel();
            lbWelcome = new Label();
            pictureBox1 = new PictureBox();
            btnLogOut = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnProfile = new Button();
            btnRevenue = new Button();
            btnBranch = new Button();
            btnProduct = new Button();
            btnhome = new Button();
            mainPanel = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(lbWelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
            // 
            // lbWelcome
            // 
            resources.ApplyResources(lbWelcome, "lbWelcome");
            lbWelcome.AutoEllipsis = true;
            lbWelcome.BackColor = Color.DodgerBlue;
            lbWelcome.ForeColor = SystemColors.Control;
            lbWelcome.Name = "lbWelcome";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            resources.ApplyResources(btnLogOut, "btnLogOut");
            btnLogOut.BackColor = Color.DodgerBlue;
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Name = "btnLogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnRevenue);
            panel2.Controls.Add(btnBranch);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(btnhome);
            panel2.Name = "panel2";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.Info;
            resources.ApplyResources(btnProfile, "btnProfile");
            btnProfile.Name = "btnProfile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnRevenue
            // 
            btnRevenue.BackColor = SystemColors.Info;
            resources.ApplyResources(btnRevenue, "btnRevenue");
            btnRevenue.Name = "btnRevenue";
            btnRevenue.UseVisualStyleBackColor = false;
            btnRevenue.Click += btnRevenue_Click;
            // 
            // btnBranch
            // 
            btnBranch.BackColor = SystemColors.Info;
            resources.ApplyResources(btnBranch, "btnBranch");
            btnBranch.Name = "btnBranch";
            btnBranch.UseVisualStyleBackColor = false;
            btnBranch.Click += btnBranch_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.Info;
            resources.ApplyResources(btnProduct, "btnProduct");
            btnProduct.Name = "btnProduct";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnhome
            // 
            btnhome.BackColor = SystemColors.Info;
            resources.ApplyResources(btnhome, "btnhome");
            btnhome.Name = "btnhome";
            btnhome.UseVisualStyleBackColor = false;
            btnhome.Click += btnhome_Click;
            // 
            // mainPanel
            // 
            resources.ApplyResources(mainPanel, "mainPanel");
            mainPanel.Name = "mainPanel";
            // 
            // AdminMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMenu";
            WindowState = FormWindowState.Maximized;
            Load += AdminMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnhome;
        private Button btnBranch;
        private Button btnProduct;
        private Label lbWelcome;
        private Button btnLogOut;
        private Button btnRevenue;
        private FlowLayoutPanel mainPanel;
        private Button btnProfile;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
    }
}