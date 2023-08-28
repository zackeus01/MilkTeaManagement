using MilkTea.Models;
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
    public partial class MainAdminHome : Form
    {
        public MainAdminHome()
        {
            InitializeComponent();
        }

        private void MainAdminHome_Load(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalBranch = db.Branches.Count();
                lbTotalBranch.Text = totalBranch.ToString();

                var totalRevenue = db.OrderDetails.Sum(od => od.TotalPrice).Value.ToString();
                lbTotalRevenue.Text = totalRevenue.ToString();

                var totalManager = db.Accounts.Where(a => a.RoleId == 2).Count();
                lbTotalManager.Text = totalManager.ToString();

                var totalEmployee = db.Accounts.Where(a => a.RoleId == 3).Count();
                lbTotalEmployee.Text = totalEmployee.ToString();
            }
        }
    }
}
