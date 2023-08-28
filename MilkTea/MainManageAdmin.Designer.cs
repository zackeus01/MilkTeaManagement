namespace MilkTea
{
    partial class MainManageAdmin
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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnDowngraded = new Button();
            btnLayyoff = new Button();
            label4 = new Label();
            txtManagerId = new TextBox();
            label13 = new Label();
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label12 = new Label();
            dgvMainManageAdmin = new DataGridView();
            panel2 = new Panel();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            btnFirstPage = new Button();
            label14 = new Label();
            btnAllManagerList = new Button();
            btnFilter = new Button();
            btnSearch = new Button();
            cbAddress = new ComboBox();
            txtSearch = new TextBox();
            btnAddManager = new Button();
            pbAvatar = new Panel();
            pbReview = new Panel();
            label15 = new Label();
            btnBrowse = new Button();
            btnSaveImage = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainManageAdmin).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 41);
            label1.TabIndex = 0;
            label1.Text = "Managers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 79);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 112);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDowngraded);
            panel1.Controls.Add(btnLayyoff);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtManagerId);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(dtDob);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtBranch);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1030, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 446);
            panel1.TabIndex = 4;
            // 
            // btnDowngraded
            // 
            btnDowngraded.Location = new Point(172, 377);
            btnDowngraded.Name = "btnDowngraded";
            btnDowngraded.Size = new Size(132, 31);
            btnDowngraded.TabIndex = 28;
            btnDowngraded.Text = "Down graded";
            btnDowngraded.UseVisualStyleBackColor = true;
            btnDowngraded.Click += btnDowngraded_Click;
            // 
            // btnLayyoff
            // 
            btnLayyoff.Location = new Point(172, 414);
            btnLayyoff.Name = "btnLayyoff";
            btnLayyoff.Size = new Size(132, 29);
            btnLayyoff.TabIndex = 27;
            btnLayyoff.Text = "Lay off";
            btnLayyoff.UseVisualStyleBackColor = true;
            btnLayyoff.Click += btnLayyoff_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(9, 10);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 27;
            label4.Text = "Manager Information";
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(102, 39);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(126, 27);
            txtManagerId.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 46);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 25;
            label13.Text = "Manager ID";
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
            btnUpdate.Location = new Point(7, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 340);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 10;
            label11.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 307);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 9;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 274);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 8;
            label9.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 171);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 7;
            label8.Text = "Dob";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 204);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 145);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Full Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 237);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Branch";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1158, 62);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 11;
            label12.Text = "Avatar";
            // 
            // dgvMainManageAdmin
            // 
            dgvMainManageAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainManageAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainManageAdmin.Location = new Point(11, 96);
            dgvMainManageAdmin.Name = "dgvMainManageAdmin";
            dgvMainManageAdmin.RowHeadersWidth = 51;
            dgvMainManageAdmin.RowTemplate.Height = 29;
            dgvMainManageAdmin.Size = new Size(968, 462);
            dgvMainManageAdmin.TabIndex = 5;
            dgvMainManageAdmin.CellClick += dgvMainManageAdmin_CellClick;
            dgvMainManageAdmin.ColumnHeaderMouseClick += dgvMainManageAdmin_ColumnHeaderMouseClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLastPage);
            panel2.Controls.Add(btnNextPage);
            panel2.Controls.Add(btnPreviousPage);
            panel2.Controls.Add(btnFirstPage);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(btnAllManagerList);
            panel2.Controls.Add(btnFilter);
            panel2.Controls.Add(btnAddManager);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cbAddress);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(dgvMainManageAdmin);
            panel2.Location = new Point(42, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 630);
            panel2.TabIndex = 6;
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(11, 28);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 22;
            label14.Text = "Managers List";
            // 
            // btnAllManagerList
            // 
            btnAllManagerList.BackColor = SystemColors.GradientInactiveCaption;
            btnAllManagerList.Location = new Point(696, 577);
            btnAllManagerList.Name = "btnAllManagerList";
            btnAllManagerList.Size = new Size(142, 29);
            btnAllManagerList.TabIndex = 21;
            btnAllManagerList.Text = "All Managers List";
            btnAllManagerList.UseVisualStyleBackColor = false;
            btnAllManagerList.Click += btnAllManagerList_Click;
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
            // btnAddManager
            // 
            btnAddManager.Location = new Point(848, 60);
            btnAddManager.Name = "btnAddManager";
            btnAddManager.Size = new Size(131, 29);
            btnAddManager.TabIndex = 10;
            btnAddManager.Text = "Add Manager";
            btnAddManager.UseVisualStyleBackColor = true;
            btnAddManager.Click += btnAddManager_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(1030, 93);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(323, 297);
            pbAvatar.TabIndex = 12;
            // 
            // pbReview
            // 
            pbReview.Location = new Point(1359, 93);
            pbReview.Name = "pbReview";
            pbReview.Size = new Size(323, 297);
            pbReview.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(1500, 62);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 14;
            label15.Text = "Review";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(1359, 397);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 15;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(1588, 396);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(94, 29);
            btnSaveImage.TabIndex = 16;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1588, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MainManageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1725, 960);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveImage);
            Controls.Add(btnBrowse);
            Controls.Add(label15);
            Controls.Add(pbReview);
            Controls.Add(panel1);
            Controls.Add(pbAvatar);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainManageAdmin";
            Text = "MainManageAdmin";
            Load += MainManageAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainManageAdmin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvMainManageAdmin;
        private Panel panel2;
        private Button btnAddManager;
        private Button btnUpdate;
        private Panel pbAvatar;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtBranch;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtDob;
        private TextBox txtManagerId;
        private Label label13;
        private TextBox txtSearch;
        private ComboBox cbAddress;
        private Button btnFilter;
        private Button btnSearch;
        private Label label14;
        private Button btnAllManagerList;
        private Label label4;
        private Button btnFirstPage;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Button btnLastPage;
        private Button btnDowngraded;
        private Button btnLayyoff;
        private Panel pbReview;
        private Label label15;
        private Button btnBrowse;
        private Button btnSaveImage;
        private Button btnCancel;
    }
}