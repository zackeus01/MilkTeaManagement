namespace MilkTea
{
    partial class MainManageBranch
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
            label1 = new Label();
            dgvMainManageBranches = new DataGridView();
            panel1 = new Panel();
            btnAllBranchesList = new Button();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            btnFirstPage = new Button();
            btnFilter = new Button();
            cbAddress = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label16 = new Label();
            btnAddBranch = new Button();
            btnBanBranch = new Button();
            label8 = new Label();
            panel2 = new Panel();
            btnUpdateBranch = new Button();
            txtTotalOfOrders = new TextBox();
            label13 = new Label();
            label15 = new Label();
            txtRevenue = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtManager = new TextBox();
            txtBranchName = new TextBox();
            txtBranchId = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMainManageBranches).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(678, 16);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 0;
            label1.Text = "Branches";
            // 
            // dgvMainManageBranches
            // 
            dgvMainManageBranches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainManageBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainManageBranches.Location = new Point(13, 95);
            dgvMainManageBranches.Name = "dgvMainManageBranches";
            dgvMainManageBranches.RowHeadersWidth = 51;
            dgvMainManageBranches.RowTemplate.Height = 29;
            dgvMainManageBranches.Size = new Size(1142, 519);
            dgvMainManageBranches.TabIndex = 2;
            dgvMainManageBranches.CellClick += dgvMainManageBranches_CellClick;
            dgvMainManageBranches.ColumnHeaderMouseClick += dgvMainManageBranches_ColumnHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAllBranchesList);
            panel1.Controls.Add(btnLastPage);
            panel1.Controls.Add(btnNextPage);
            panel1.Controls.Add(btnPreviousPage);
            panel1.Controls.Add(btnFirstPage);
            panel1.Controls.Add(btnFilter);
            panel1.Controls.Add(cbAddress);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(btnAddBranch);
            panel1.Controls.Add(dgvMainManageBranches);
            panel1.Location = new Point(54, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 700);
            panel1.TabIndex = 9;
            // 
            // btnAllBranchesList
            // 
            btnAllBranchesList.BackColor = SystemColors.GradientInactiveCaption;
            btnAllBranchesList.Location = new Point(784, 633);
            btnAllBranchesList.Name = "btnAllBranchesList";
            btnAllBranchesList.Size = new Size(142, 29);
            btnAllBranchesList.TabIndex = 28;
            btnAllBranchesList.Text = "All Branches List";
            btnAllBranchesList.UseVisualStyleBackColor = false;
            btnAllBranchesList.Click += btnAllBranchesList_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.BackColor = SystemColors.ButtonHighlight;
            btnLastPage.Location = new Point(660, 633);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(94, 29);
            btnLastPage.TabIndex = 27;
            btnLastPage.Text = "Last Page";
            btnLastPage.UseVisualStyleBackColor = false;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = SystemColors.Info;
            btnNextPage.Location = new Point(535, 633);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 26;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = SystemColors.Info;
            btnPreviousPage.Location = new Point(411, 633);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 25;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.BackColor = SystemColors.ButtonHighlight;
            btnFirstPage.ForeColor = SystemColors.ControlText;
            btnFirstPage.Location = new Point(282, 633);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(94, 29);
            btnFirstPage.TabIndex = 24;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(521, 57);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 22;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // cbAddress
            // 
            cbAddress.FormattingEnabled = true;
            cbAddress.Items.AddRange(new object[] { "Ha Noi", "Hai Duong", "Hai Phong", "Nam Sach", "Tuyen Quang", "Da Nang ", "Hue" });
            cbAddress.Location = new Point(364, 57);
            cbAddress.Name = "cbAddress";
            cbAddress.Size = new Size(151, 28);
            cbAddress.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(206, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 59);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Branch name or Phone....";
            txtSearch.Size = new Size(187, 27);
            txtSearch.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(13, 29);
            label16.Name = "label16";
            label16.Size = new Size(121, 20);
            label16.TabIndex = 10;
            label16.Text = "List of Branches";
            // 
            // btnAddBranch
            // 
            btnAddBranch.Location = new Point(1061, 56);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(94, 29);
            btnAddBranch.TabIndex = 13;
            btnAddBranch.Text = "Add Branch";
            btnAddBranch.UseVisualStyleBackColor = true;
            btnAddBranch.Click += btnAddBranch_Click;
            // 
            // btnBanBranch
            // 
            btnBanBranch.Location = new Point(160, 297);
            btnBanBranch.Name = "btnBanBranch";
            btnBanBranch.Size = new Size(94, 29);
            btnBanBranch.TabIndex = 15;
            btnBanBranch.Text = "Ban";
            btnBanBranch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 32);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 10;
            label8.Text = "BranchId ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUpdateBranch);
            panel2.Controls.Add(txtTotalOfOrders);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnBanBranch);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtRevenue);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtManager);
            panel2.Controls.Add(txtBranchName);
            panel2.Controls.Add(txtBranchId);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(1240, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 329);
            panel2.TabIndex = 11;
            // 
            // btnUpdateBranch
            // 
            btnUpdateBranch.Location = new Point(12, 297);
            btnUpdateBranch.Name = "btnUpdateBranch";
            btnUpdateBranch.Size = new Size(94, 29);
            btnUpdateBranch.TabIndex = 14;
            btnUpdateBranch.Text = "Update";
            btnUpdateBranch.UseVisualStyleBackColor = true;
            btnUpdateBranch.Click += btnUpdateBranch_Click;
            // 
            // txtTotalOfOrders
            // 
            txtTotalOfOrders.Location = new Point(129, 193);
            txtTotalOfOrders.Name = "txtTotalOfOrders";
            txtTotalOfOrders.Size = new Size(125, 27);
            txtTotalOfOrders.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 200);
            label13.Name = "label13";
            label13.Size = new Size(110, 20);
            label13.TabIndex = 25;
            label13.Text = "Total Of Orders";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(15, 6);
            label15.Name = "label15";
            label15.Size = new Size(147, 20);
            label15.TabIndex = 24;
            label15.Text = "Branch Information";
            // 
            // txtRevenue
            // 
            txtRevenue.Location = new Point(129, 235);
            txtRevenue.Name = "txtRevenue";
            txtRevenue.Size = new Size(125, 27);
            txtRevenue.TabIndex = 23;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(129, 161);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 21;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(129, 128);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 20;
            // 
            // txtManager
            // 
            txtManager.Location = new Point(129, 95);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(125, 27);
            txtManager.TabIndex = 19;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(129, 62);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(125, 27);
            txtBranchName.TabIndex = 18;
            // 
            // txtBranchId
            // 
            txtBranchId.Location = new Point(129, 29);
            txtBranchId.Name = "txtBranchId";
            txtBranchId.Size = new Size(125, 27);
            txtBranchId.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 238);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 16;
            label14.Text = "REVENUE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 168);
            label12.Name = "label12";
            label12.Size = new Size(62, 20);
            label12.TabIndex = 14;
            label12.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 135);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 13;
            label11.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 102);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 12;
            label10.Text = "Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 69);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 11;
            label9.Text = "Branch Name ";
            // 
            // MainManageBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 935);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainManageBranch";
            Text = "BranchesManagement";
            Load += MainManageBranch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMainManageBranches).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMainManageBranches;
        private Panel panel1;
        private Label label16;
        private Label label8;
        private Panel panel2;
        private Label label15;
        private TextBox txtRevenue;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtManager;
        private TextBox txtBranchName;
        private TextBox txtBranchId;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtTotalOfOrders;
        private Label label13;
        private Button btnAddBranch;
        private Button btnUpdateBranch;
        private Button btnBanBranch;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cbAddress;
        private Button btnFilter;
        private Button btnFirstPage;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Button btnLastPage;
        private Button btnAllBranchesList;
    }
}