namespace MilkTea
{
    partial class AdminProfile
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            dtDob = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            btnUpdate = new Button();
            label11 = new Label();
            label12 = new Label();
            txtNewPass = new TextBox();
            txtReNewPass = new TextBox();
            btnSave = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnTogglePassword = new Button();
            btnUpdateAccount = new Button();
            btnCancel = new Button();
            pbAvatar = new Panel();
            label23 = new Label();
            btnViewNewPass = new Button();
            btnViewReBewPass = new Button();
            pbReview = new Panel();
            btnBrowse = new Button();
            btnSaveImage = new Button();
            btnCancelImage = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(565, 18);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Manager Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 182);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 247);
            label5.Name = "label5";
            label5.Size = new Size(57, 31);
            label5.TabIndex = 4;
            label5.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 315);
            label6.Name = "label6";
            label6.Size = new Size(78, 31);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 456);
            label7.Name = "label7";
            label7.Size = new Size(97, 31);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 386);
            label8.Name = "label8";
            label8.Size = new Size(70, 31);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 8;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.Location = new Point(158, 189);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(64, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.Location = new Point(248, 189);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(79, 24);
            rbFemale.TabIndex = 10;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtDob
            // 
            dtDob.CustomFormat = "dd/MM/yyyy";
            dtDob.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtDob.Format = DateTimePickerFormat.Custom;
            dtDob.Location = new Point(158, 251);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(250, 27);
            dtDob.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(158, 318);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 460);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(617, 294);
            label9.Name = "label9";
            label9.Size = new Size(98, 31);
            label9.TabIndex = 15;
            label9.Text = "Account";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(617, 347);
            label10.Name = "label10";
            label10.Size = new Size(110, 31);
            label10.TabIndex = 16;
            label10.Text = "Password";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(744, 296);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(250, 27);
            txtAccount.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(744, 351);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonHighlight;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(48, 577);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 42);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update Manager";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(565, 400);
            label11.Name = "label11";
            label11.Size = new Size(162, 31);
            label11.TabIndex = 20;
            label11.Text = "New Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(544, 457);
            label12.Name = "label12";
            label12.Size = new Size(183, 31);
            label12.TabIndex = 21;
            label12.Text = "Renew Password";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(744, 402);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(250, 27);
            txtNewPass.TabIndex = 22;
            // 
            // txtReNewPass
            // 
            txtReNewPass.Location = new Point(744, 461);
            txtReNewPass.Name = "txtReNewPass";
            txtReNewPass.Size = new Size(250, 27);
            txtReNewPass.TabIndex = 23;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(805, 577);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 42);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save Change Password";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = SystemColors.Info;
            btnTogglePassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTogglePassword.Location = new Point(1003, 347);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(54, 27);
            btnTogglePassword.TabIndex = 25;
            btnTogglePassword.Text = "View";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = SystemColors.ButtonHighlight;
            btnUpdateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAccount.Location = new Point(665, 577);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(134, 42);
            btnUpdateAccount.TabIndex = 26;
            btnUpdateAccount.Text = "Update Account";
            btnUpdateAccount.UseVisualStyleBackColor = false;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Info;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(987, 577);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 42);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(744, 92);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(250, 198);
            pbAvatar.TabIndex = 29;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(828, 58);
            label23.Name = "label23";
            label23.Size = new Size(80, 31);
            label23.TabIndex = 41;
            label23.Text = "Avatar";
            // 
            // btnViewNewPass
            // 
            btnViewNewPass.BackColor = Color.MistyRose;
            btnViewNewPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewNewPass.Location = new Point(1003, 400);
            btnViewNewPass.Name = "btnViewNewPass";
            btnViewNewPass.Size = new Size(54, 29);
            btnViewNewPass.TabIndex = 42;
            btnViewNewPass.Text = "View";
            btnViewNewPass.UseVisualStyleBackColor = false;
            btnViewNewPass.Click += btnViewNewPass_Click;
            // 
            // btnViewReBewPass
            // 
            btnViewReBewPass.BackColor = Color.MistyRose;
            btnViewReBewPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewReBewPass.Location = new Point(1003, 461);
            btnViewReBewPass.Name = "btnViewReBewPass";
            btnViewReBewPass.Size = new Size(54, 29);
            btnViewReBewPass.TabIndex = 43;
            btnViewReBewPass.Text = "View";
            btnViewReBewPass.UseVisualStyleBackColor = false;
            btnViewReBewPass.Click += btnViewReBewPass_Click;
            // 
            // pbReview
            // 
            pbReview.Location = new Point(1022, 90);
            pbReview.Name = "pbReview";
            pbReview.Size = new Size(250, 198);
            pbReview.TabIndex = 44;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ButtonHighlight;
            btnBrowse.Location = new Point(1022, 298);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 45;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.BackColor = SystemColors.ButtonHighlight;
            btnSaveImage.Location = new Point(1178, 296);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(94, 29);
            btnSaveImage.TabIndex = 46;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = false;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // btnCancelImage
            // 
            btnCancelImage.BackColor = SystemColors.ButtonHighlight;
            btnCancelImage.Location = new Point(1178, 331);
            btnCancelImage.Name = "btnCancelImage";
            btnCancelImage.Size = new Size(94, 29);
            btnCancelImage.TabIndex = 47;
            btnCancelImage.Text = "Cancel Image";
            btnCancelImage.UseVisualStyleBackColor = false;
            btnCancelImage.Click += btnCancelImage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1110, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 48;
            label2.Text = "Review";
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1601, 909);
            Controls.Add(label2);
            Controls.Add(btnCancelImage);
            Controls.Add(btnSaveImage);
            Controls.Add(btnBrowse);
            Controls.Add(pbReview);
            Controls.Add(btnViewReBewPass);
            Controls.Add(btnViewNewPass);
            Controls.Add(label23);
            Controls.Add(pbAvatar);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateAccount);
            Controls.Add(btnTogglePassword);
            Controls.Add(btnSave);
            Controls.Add(txtReNewPass);
            Controls.Add(txtNewPass);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(dtDob);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProfile";
            Text = "AdminProfile";
            Load += AdminProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private DateTimePicker dtDob;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label9;
        private Label label10;
        private TextBox txtAccount;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Label label11;
        private Label label12;
        private TextBox txtNewPass;
        private TextBox txtReNewPass;
        private Button btnSave;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnTogglePassword;
        private Button btnUpdateAccount;
        private Button btnCancel;
        private Panel pbAvatar;
        private Label label23;
        private Button btnViewNewPass;
        private Button btnViewReBewPass;
        private Panel pbReview;
        private Button btnBrowse;
        private Button btnSaveImage;
        private Button btnCancelImage;
        private Label label2;
    }
}