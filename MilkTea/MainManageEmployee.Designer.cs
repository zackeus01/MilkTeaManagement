namespace MilkTea
{
    partial class MainManageEmployee
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
            pbAvatar = new Panel();
            label15 = new Label();
            btnAddManager = new Button();
            label14 = new Label();
            panel3 = new Panel();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            btnFirstPage = new Button();
            btnAllEmployeeList = new Button();
            btnFilter = new Button();
            btnSearch = new Button();
            cbAddress = new ComboBox();
            txtSearch = new TextBox();
            dgvMainManageEmployee = new DataGridView();
            btnUpgraded = new Button();
            btnLayoff = new Button();
            panel2 = new Panel();
            label2 = new Label();
            txtEmpId = new TextBox();
            label17 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtDob = new DateTimePicker();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtBranch = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnUpdate = new Button();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            pbReview = new Panel();
            label3 = new Label();
            btnBrowse = new Button();
            btnSaveImage = new Button();
            btnCancel = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainManageEmployee).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(588, 11);
            label1.Name = "label1";
            label1.Size = new Size(168, 41);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(1023, 66);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(323, 297);
            pbAvatar.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(11, 28);
            label15.Name = "label15";
            label15.Size = new Size(134, 20);
            label15.TabIndex = 17;
            label15.Text = "List Of Employees";
            // 
            // btnAddManager
            // 
            btnAddManager.Location = new Point(848, 60);
            btnAddManager.Name = "btnAddManager";
            btnAddManager.Size = new Size(131, 29);
            btnAddManager.TabIndex = 15;
            btnAddManager.Text = "Add Employee";
            btnAddManager.UseVisualStyleBackColor = true;
            btnAddManager.Click += btnAddManager_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1159, 32);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 16;
            label14.Text = "Avatar";
            // 
            // panel3
            // 
            panel3.Controls.Add(label15);
            panel3.Controls.Add(btnLastPage);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnPreviousPage);
            panel3.Controls.Add(btnFirstPage);
            panel3.Controls.Add(btnAllEmployeeList);
            panel3.Controls.Add(btnFilter);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(btnAddManager);
            panel3.Controls.Add(cbAddress);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(dgvMainManageEmployee);
            panel3.Location = new Point(35, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 630);
            panel3.TabIndex = 17;
            // 
            // btnLastPage
            // 
            btnLastPage.BackColor = SystemColors.ButtonHighlight;
            btnLastPage.Location = new Point(573, 577);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(94, 29);
            btnLastPage.TabIndex = 26;
            btnLastPage.Text = "Last Page";
            btnLastPage.UseVisualStyleBackColor = false;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = SystemColors.Info;
            btnNextPage.Location = new Point(457, 577);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 25;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = SystemColors.Info;
            btnPreviousPage.Location = new Point(343, 577);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 24;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.BackColor = SystemColors.ButtonHighlight;
            btnFirstPage.ForeColor = SystemColors.ControlText;
            btnFirstPage.Location = new Point(228, 577);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(94, 29);
            btnFirstPage.TabIndex = 23;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnAllEmployeeList
            // 
            btnAllEmployeeList.BackColor = SystemColors.GradientInactiveCaption;
            btnAllEmployeeList.Location = new Point(696, 577);
            btnAllEmployeeList.Name = "btnAllEmployeeList";
            btnAllEmployeeList.Size = new Size(142, 29);
            btnAllEmployeeList.TabIndex = 21;
            btnAllEmployeeList.Text = "All Employees List";
            btnAllEmployeeList.UseVisualStyleBackColor = false;
            btnAllEmployeeList.Click += btnAllEmployeeList_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(521, 62);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 20;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(194, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbAddress
            // 
            cbAddress.FormattingEnabled = true;
            cbAddress.Items.AddRange(new object[] { "Ha Noi", "Hai Duong", "Hai Phong", "Nam Sach", "Tuyen Quang", "Da Nang ", "Hue" });
            cbAddress.Location = new Point(364, 61);
            cbAddress.Name = "cbAddress";
            cbAddress.Size = new Size(151, 28);
            cbAddress.TabIndex = 18;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Username or Email....";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 17;
            // 
            // dgvMainManageEmployee
            // 
            dgvMainManageEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainManageEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainManageEmployee.Location = new Point(11, 96);
            dgvMainManageEmployee.Name = "dgvMainManageEmployee";
            dgvMainManageEmployee.RowHeadersWidth = 51;
            dgvMainManageEmployee.RowTemplate.Height = 29;
            dgvMainManageEmployee.Size = new Size(968, 462);
            dgvMainManageEmployee.TabIndex = 5;
            dgvMainManageEmployee.CellClick += dgvMainManageEmployee_CellClick;
            dgvMainManageEmployee.ColumnHeaderMouseClick += dgvMainManageEmployee_ColumnHeaderMouseClick;
            // 
            // btnUpgraded
            // 
            btnUpgraded.Location = new Point(215, 366);
            btnUpgraded.Name = "btnUpgraded";
            btnUpgraded.Size = new Size(105, 34);
            btnUpgraded.TabIndex = 28;
            btnUpgraded.Text = "Up graded";
            btnUpgraded.UseVisualStyleBackColor = true;
            btnUpgraded.Click += btnUpgraded_Click;
            // 
            // btnLayoff
            // 
            btnLayoff.Location = new Point(215, 406);
            btnLayoff.Name = "btnLayoff";
            btnLayoff.Size = new Size(105, 29);
            btnLayoff.TabIndex = 27;
            btnLayoff.Text = "Lay off";
            btnLayoff.UseVisualStyleBackColor = true;
            btnLayoff.Click += btnLayoff_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnUpgraded);
            panel2.Controls.Add(txtEmpId);
            panel2.Controls.Add(btnLayoff);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(rbFemale);
            panel2.Controls.Add(rbMale);
            panel2.Controls.Add(dtDob);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtBranch);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(label26);
            panel2.Location = new Point(1023, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 438);
            panel2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 27;
            label2.Text = "Employee Information";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(102, 39);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(126, 27);
            txtEmpId.TabIndex = 26;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 46);
            label17.Name = "label17";
            label17.Size = new Size(94, 20);
            label17.TabIndex = 25;
            label17.Text = "Employee ID";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(172, 204);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 24;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(103, 204);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 23;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtDob
            // 
            dtDob.CustomFormat = "dd/MM/yyyy";
            dtDob.Format = DateTimePickerFormat.Custom;
            dtDob.Location = new Point(103, 171);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(201, 27);
            dtDob.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(103, 333);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(102, 267);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 19;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(103, 234);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(125, 27);
            txtBranch.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(103, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(103, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(3, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 340);
            label18.Name = "label18";
            label18.Size = new Size(62, 20);
            label18.TabIndex = 10;
            label18.Text = "Address";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 307);
            label19.Name = "label19";
            label19.Size = new Size(46, 20);
            label19.TabIndex = 9;
            label19.Text = "Email";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 274);
            label20.Name = "label20";
            label20.Size = new Size(50, 20);
            label20.TabIndex = 8;
            label20.Text = "Phone";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 171);
            label21.Name = "label21";
            label21.Size = new Size(38, 20);
            label21.TabIndex = 7;
            label21.Text = "Dob";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(14, 204);
            label22.Name = "label22";
            label22.Size = new Size(57, 20);
            label22.TabIndex = 6;
            label22.Text = "Gender";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(7, 145);
            label23.Name = "label23";
            label23.Size = new Size(76, 20);
            label23.TabIndex = 5;
            label23.Text = "Full Name";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(14, 237);
            label24.Name = "label24";
            label24.Size = new Size(54, 20);
            label24.TabIndex = 4;
            label24.Text = "Branch";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 79);
            label25.Name = "label25";
            label25.Size = new Size(82, 20);
            label25.TabIndex = 1;
            label25.Text = "User Name";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(7, 112);
            label26.Name = "label26";
            label26.Size = new Size(70, 20);
            label26.TabIndex = 2;
            label26.Text = "Password";
            // 
            // pbReview
            // 
            pbReview.Location = new Point(1352, 66);
            pbReview.Name = "pbReview";
            pbReview.Size = new Size(320, 297);
            pbReview.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1479, 32);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 20;
            label3.Text = "Review";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(1352, 369);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(1578, 370);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(94, 29);
            btnSaveImage.TabIndex = 22;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1578, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MainManageEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 908);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveImage);
            Controls.Add(btnBrowse);
            Controls.Add(label3);
            Controls.Add(pbReview);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label14);
            Controls.Add(pbAvatar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainManageEmployee";
            Text = "MainManageEmployee";
            Load += MainManageEmployee_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainManageEmployee).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pbAvatar;
        private Button btnAddManager;
        private Label label14;
        private Label label15;
        private Panel panel3;
        private Button btnUpgraded;
        private Button btnLayoff;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Button btnFirstPage;
        private Button btnAllEmployeeList;
        private Button btnFilter;
        private Button btnSearch;
        private ComboBox cbAddress;
        private TextBox txtSearch;
        private DataGridView dgvMainManageEmployee;
        private Panel panel2;
        private TextBox txtEmpId;
        private Label label17;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtDob;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtBranch;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnUpdate;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Panel pbReview;
        private Label label3;
        private Button btnBrowse;
        private Button btnSaveImage;
        private Button btnCancel;
    }
}