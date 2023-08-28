namespace MilkTea
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			btnForgotPassword = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = SystemColors.Control;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.DodgerBlue;
			label1.Location = new Point(447, 122);
			label1.Name = "label1";
			label1.Size = new Size(301, 46);
			label1.TabIndex = 0;
			label1.Text = "Welcome MilkTea";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(374, 234);
			label2.Name = "label2";
			label2.Size = new Size(133, 31);
			label2.TabIndex = 1;
			label2.Text = "Username :";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(374, 340);
			label3.Name = "label3";
			label3.Size = new Size(126, 31);
			label3.TabIndex = 2;
			label3.Text = "Password :";
			// 
			// txtUsername
			// 
			txtUsername.Anchor = AnchorStyles.None;
			txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.Location = new Point(374, 280);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(415, 43);
			txtUsername.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.Anchor = AnchorStyles.None;
			txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(374, 385);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(415, 38);
			txtPassword.TabIndex = 4;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Anchor = AnchorStyles.None;
			btnLogin.BackColor = SystemColors.Info;
			btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.ForeColor = SystemColors.Desktop;
			btnLogin.Location = new Point(447, 462);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(229, 51);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnForgotPassword
			// 
			btnForgotPassword.Anchor = AnchorStyles.None;
			btnForgotPassword.Location = new Point(738, 477);
			btnForgotPassword.Name = "btnForgotPassword";
			btnForgotPassword.Size = new Size(217, 29);
			btnForgotPassword.TabIndex = 6;
			btnForgotPassword.Text = "Forgot Password";
			btnForgotPassword.UseVisualStyleBackColor = true;
			btnForgotPassword.Click += btnForgotPassword_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(1179, 677);
			Controls.Add(btnForgotPassword);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			WindowState = FormWindowState.Maximized;
			Load += Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
		private Button btnForgotPassword;
	}
}