namespace MilkTea
{
	partial class ForgotPassword
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
			btnSendOTP = new Button();
			txtUsername = new TextBox();
			txtEmail = new TextBox();
			txtOTP = new TextBox();
			txtSubmit = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(171, 94);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 0;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(171, 156);
			label2.Name = "label2";
			label2.Size = new Size(46, 20);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(291, 34);
			label3.Name = "label3";
			label3.Size = new Size(150, 20);
			label3.TabIndex = 2;
			label3.Text = "FORGOT PASSWORD ";
			// 
			// btnSendOTP
			// 
			btnSendOTP.Location = new Point(493, 224);
			btnSendOTP.Name = "btnSendOTP";
			btnSendOTP.Size = new Size(94, 29);
			btnSendOTP.TabIndex = 3;
			btnSendOTP.Text = "Send OTP";
			btnSendOTP.UseVisualStyleBackColor = true;
			btnSendOTP.Click += btnSendOTP_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(262, 91);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(203, 27);
			txtUsername.TabIndex = 4;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(262, 156);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(203, 27);
			txtEmail.TabIndex = 5;
			// 
			// txtOTP
			// 
			txtOTP.Location = new Point(262, 224);
			txtOTP.Name = "txtOTP";
			txtOTP.Size = new Size(203, 27);
			txtOTP.TabIndex = 6;
			// 
			// txtSubmit
			// 
			txtSubmit.Location = new Point(311, 289);
			txtSubmit.Name = "txtSubmit";
			txtSubmit.Size = new Size(94, 29);
			txtSubmit.TabIndex = 7;
			txtSubmit.Text = "Submit";
			txtSubmit.UseVisualStyleBackColor = true;
			txtSubmit.Click += txtSubmit_Click;
			// 
			// ForgotPassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtSubmit);
			Controls.Add(txtOTP);
			Controls.Add(txtEmail);
			Controls.Add(txtUsername);
			Controls.Add(btnSendOTP);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ForgotPassword";
			Text = "ForgotPassword";
			Load += ForgotPassword_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnSendOTP;
		private TextBox txtUsername;
		private TextBox txtEmail;
		private TextBox txtOTP;
		private Button txtSubmit;
	}
}