namespace MilkTea
{
	partial class ChangePassword
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
			txtPassword = new TextBox();
			label1 = new Label();
			btnChange = new Button();
			btnReturn = new Button();
			txtUsername = new TextBox();
			UserName = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(266, 209);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(228, 27);
			txtPassword.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(307, 70);
			label1.Name = "label1";
			label1.Size = new Size(124, 20);
			label1.TabIndex = 1;
			label1.Text = "Change Password";
			// 
			// btnChange
			// 
			btnChange.Location = new Point(202, 272);
			btnChange.Name = "btnChange";
			btnChange.Size = new Size(94, 29);
			btnChange.TabIndex = 2;
			btnChange.Text = "Change";
			btnChange.UseVisualStyleBackColor = true;
			btnChange.Click += btnChange_Click;
			// 
			// btnReturn
			// 
			btnReturn.Location = new Point(428, 272);
			btnReturn.Name = "btnReturn";
			btnReturn.Size = new Size(143, 29);
			btnReturn.TabIndex = 3;
			btnReturn.Text = "Return Login";
			btnReturn.UseVisualStyleBackColor = true;
			btnReturn.Click += btnReturn_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(266, 138);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(228, 27);
			txtUsername.TabIndex = 4;
			// 
			// UserName
			// 
			UserName.AutoSize = true;
			UserName.Location = new Point(163, 141);
			UserName.Name = "UserName";
			UserName.Size = new Size(78, 20);
			UserName.TabIndex = 5;
			UserName.Text = "UserName";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(163, 209);
			label3.Name = "label3";
			label3.Size = new Size(70, 20);
			label3.TabIndex = 6;
			label3.Text = "Password";
			// 
			// ChangePassword
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(UserName);
			Controls.Add(txtUsername);
			Controls.Add(btnReturn);
			Controls.Add(btnChange);
			Controls.Add(label1);
			Controls.Add(txtPassword);
			Name = "ChangePassword";
			Text = "ChangePassword";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtPassword;
		private Label label1;
		private Button btnChange;
		private Button btnReturn;
		private TextBox txtUsername;
		private Label UserName;
		private Label label3;
	}
}