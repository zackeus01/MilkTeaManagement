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
    public partial class MainAddBranch : Form
    {
        public MainAddBranch()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                Branch newBranch = new Branch
                {
                    BranchName = txtBranchName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    ManagerId = int.Parse(txtManagerId.Text)
                };
                db.Branches.Add(newBranch);
                db.SaveChanges();

                MessageBox.Show("Branch is added success");

                // đóng forrm
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
