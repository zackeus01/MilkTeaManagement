using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea
{
	public partial class ChangePassword : Form
	{
		private readonly MilkteaDBContext db = new MilkteaDBContext();
		public ChangePassword()
		{
			InitializeComponent();
		}
		private string username;
		private string newPassword;
		private void btnChange_Click(object sender, EventArgs e)
		{

			username = txtUsername.Text;
			newPassword = txtPassword.Text;
			

			
			
				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
				{
					MessageBox.Show("Please input username and password");
					return;
				}
				var user = db.Accounts.FirstOrDefault(x => x.Username == username);
				/*var pass = db.Accounts.FirstOrDefault(x => x.Password == newPassword);*/
				if(user == null )
				{
					MessageBox.Show("Username is incorrect !");
				return;
				}
				
				user.Password = newPassword;
				db.SaveChanges();

				MessageBox.Show("Password has been changed successfully");
			
			
			

		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			Login ReturnLogin = new Login();
			ReturnLogin.Show();
			this.Hide();
		}
	}
}
