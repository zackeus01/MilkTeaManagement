using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea
{
    public partial class MainAdminDashboard : Form
    {
        public MainAdminDashboard()
        {
            InitializeComponent();
        }

        private void MainAdminManagement_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MainAdminHome mainAdminHome = new MainAdminHome();
            mainAdminHome.TopLevel = false;
            mainPanel.Controls.Add(mainAdminHome);
            mainAdminHome.Show();
        }

        // adminmanagement Home - Kienbv
        private void btnHome_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MainAdminHome mainAdminHome = new MainAdminHome();
            mainAdminHome.TopLevel = false;
            mainPanel.Controls.Add(mainAdminHome);
            mainAdminHome.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MainManageAdmin mainManageAdmin = new MainManageAdmin();
            mainManageAdmin.TopLevel = false;
            mainPanel.Controls.Add(mainManageAdmin);
            mainManageAdmin.Show();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MainManageBranch mainManageBranch = new MainManageBranch();
            mainManageBranch.TopLevel = false;
            mainPanel.Controls.Add(mainManageBranch);
            mainManageBranch.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            MainManageEmployee mainManageEmployee = new MainManageEmployee();
            mainManageEmployee.TopLevel = false;
            mainPanel.Controls.Add(mainManageEmployee);
            mainManageEmployee.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
