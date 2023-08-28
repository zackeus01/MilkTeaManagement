using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using MilkTea.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace MilkTea
{
	public partial class Login : Form
	{
		private readonly MilkteaDBContext db = new MilkteaDBContext();
        //public Login()
        //{
        //    InitializeComponent();
        //}
        //string user;
        //string pass;
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    Account ac = new Account();
        //    user = txtUsername.Text.Trim();
        //    pass = txtPassword.Text.Trim();
        //    var username = db.Accounts.FirstOrDefault(x => x.Username == user);
        //    var password = db.Accounts.FirstOrDefault(y => y.Password == pass);
        //    if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) == null)
        //    {
        //        MessageBox.Show("Please enter username and password");
        //        return;

        //    }
        //    if (username == null || password == null)
        //    {
        //        MessageBox.Show("Username or password is incorrect");
        //        return;
        //    }

        //    if (ac.RoleId == 2)
        //    {
        //        AdminMenu manager = new AdminMenu();
        //        manager.Show();
        //        this.Hide();
        //    }
        //    if (ac.RoleId == 1)
        //    {
        //        MainAdminDashboard admin = new MainAdminDashboard();
        //        admin.Show();
        //        this.Hide();
        //    }
        //    if (ac.RoleId == 3)
        //    {
        //        // Role = 3 cho Employee
        //    }
        //}

        public Login()
        {
            InitializeComponent();
        }
        Account accountList = new Account();
        Role roleList = new Role();
        public bool validAccount()
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                return false;
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9_\.]+)$");
            if (!regex.IsMatch(user) || !regex.IsMatch(pass))
            {
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            using (var context = new MilkteaDBContext())
            {
                Account ac = context.Accounts.Include(ac => ac.Branch).FirstOrDefault(ac => ac.Username.Equals(user) && ac.Password.Equals(pass));
                if (ac == null)
                {
                    MessageBox.Show("Dang nhap that bai");
                }
                else
                {
                    int accountId = ac.AccountId;
                    //admin
                    if (ac.RoleId == 1)
                    {
                        MainAdminDashboard form = new MainAdminDashboard();
                        form.Show();
                        this.Hide();
                    }
                    
                    //manager
                    if (ac.RoleId == 2)
                    {
                        AdminMenu adminMenu = new AdminMenu(ac);
						adminMenu.Show();
                        this.Hide();
                    }

                    //employee
                    if (ac.RoleId == 3)
                    {
                        EmployeeMenu employeeMenu = new EmployeeMenu(ac);
                        employeeMenu.Show();
                        this.Hide();
                    }
                }

            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
		{
			ForgotPassword formForgotPassword = new ForgotPassword(); // Tạo và hiển thị form ChangePassword
			formForgotPassword.Show();
			this.Hide();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}