using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.VisualBasic.Logging;
using MilkTea.Models;
using MilkTeaManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilkTea
{
    public partial class AdminMenu : Form
    {
        private readonly MilkteaDBContext db = new MilkteaDBContext();
        Account manager;
        internal static int AccountId;

        public AdminMenu()
        {
            InitializeComponent();
            var Manager = db.Accounts.Where(a => a.RoleId == 2 && a.AccountId == AccountId).Select(a => a.Name).FirstOrDefault();
            lbWelcome.Text = "Welcome Manager " + Manager.ToString();
        }

        public AdminMenu(Account ac)
        {
            InitializeComponent();
            manager = ac;
            lbWelcome.Text = "Welcome Manager " + manager.Name;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            getHome();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdminProduct adminProduct = new AdminProduct(manager);
            adminProduct.AccountId = AccountId;
            adminProduct.TopLevel = false;
            mainPanel.Controls.Add(adminProduct);
            adminProduct.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            getHome();
        }

        private void getHome()
        {
            AdminHome home = new AdminHome();
            home.TopLevel = false;
            mainPanel.Controls.Add(home);
            home.Show();
        }

        // Kienbv
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdminRevenue adminRevenue = new AdminRevenue(manager);
            adminRevenue.TopLevel = false;
            mainPanel.Controls.Add(adminRevenue);
            adminRevenue.Show();
        }

        // Kienbv
        private void btnBranch_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdminBranch adminBranch = new AdminBranch();
            adminBranch.TopLevel = false;
            mainPanel.Controls.Add(adminBranch);
            adminBranch.Show();
        }

        // Kienbv
        private void btnProfile_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdminProfile adminProfile = new AdminProfile(manager);
            adminProfile.TopLevel = false;
            mainPanel.Controls.Add(adminProfile);
            adminProfile.Show();
        }
    }
}
