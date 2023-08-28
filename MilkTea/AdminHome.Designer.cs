
namespace MilkTeaManagement
{
	partial class AdminHome
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
			panel1 = new Panel();
			label4 = new Label();
			label1 = new Label();
			panel2 = new Panel();
			label5 = new Label();
			label2 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.IndianRed;
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(57, 99);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(229, 133);
			panel1.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(18, 77);
			label4.Name = "label4";
			label4.Size = new Size(104, 41);
			label4.TabIndex = 1;
			label4.Text = "label4";
			label4.Click += label4_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(18, 21);
			label1.Name = "label1";
			label1.Size = new Size(133, 32);
			label1.TabIndex = 0;
			label1.Text = "Total Oder";
			// 
			// panel2
			// 
			panel2.BackColor = Color.OliveDrab;
			panel2.Controls.Add(label5);
			panel2.Controls.Add(label2);
			panel2.Location = new Point(508, 99);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(229, 133);
			panel2.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(18, 77);
			label5.Name = "label5";
			label5.Size = new Size(104, 41);
			label5.TabIndex = 2;
			label5.Text = "label5";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(18, 21);
			label2.Name = "label2";
			label2.Size = new Size(168, 32);
			label2.TabIndex = 0;
			label2.Text = "Total Product";
			// 
			// AdminHome
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 359);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			Name = "AdminHome";
			StartPosition = FormStartPosition.CenterParent;
			Text = "AdminHome";
			Load += AdminHome_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label4;
		private Label label1;
		private Panel panel2;
		private Label label5;
		private Label label2;
	}
}