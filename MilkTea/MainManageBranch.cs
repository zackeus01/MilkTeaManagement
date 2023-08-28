using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.ExtendedProperties;
using MilkTea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MilkTea
{
    public partial class MainManageBranch : Form
    {
        public MainManageBranch()
        {
            InitializeComponent();
        }

        private void MainManageBranch_Load(object sender, EventArgs e)
        {
            txtBranchId.ReadOnly = true;
            LoadBranches();
            // cho việc sort khi click vào title
            dgvMainManageBranches.ColumnHeaderMouseClick += dgvMainManageBranches_ColumnHeaderMouseClick;
        }

        private void LoadBranches()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvMainManageBranches.AutoGenerateColumns = false;
                dgvMainManageBranches.Columns.Clear();
                dgvMainManageBranches.DataSource = null;

                var branchesList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                ManagerName = b.ManagerId,
                Phone = b.Phone,
                Address = b.Address,
                TotalOrderSum = b.Orders.Sum(o => o.Total),
                Revenue = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice)
            }).ToList();

                dgvMainManageBranches.DataSource = branchesList;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn branchId = new DataGridViewTextBoxColumn();
                branchId.Name = "BranchId";
                branchId.HeaderText = "Branch ID";
                branchId.DataPropertyName = "BranchId";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn managerName = new DataGridViewTextBoxColumn();
                managerName.Name = "ManagerName";
                managerName.HeaderText = "Manager Name";
                managerName.DataPropertyName = "ManagerName";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalOrderSum = new DataGridViewTextBoxColumn();
                totalOrderSum.Name = "TotalOrderSum";
                totalOrderSum.HeaderText = "Total Of Orders";
                totalOrderSum.DataPropertyName = "TotalOrderSum";

                DataGridViewTextBoxColumn revenue = new DataGridViewTextBoxColumn();
                revenue.Name = "Revenue";
                revenue.HeaderText = "Revenue";
                revenue.DataPropertyName = "Revenue";

                dgvMainManageBranches.Columns.Add(branchId);
                dgvMainManageBranches.Columns.Add(branchName);
                dgvMainManageBranches.Columns.Add(managerName);
                dgvMainManageBranches.Columns.Add(phone);
                dgvMainManageBranches.Columns.Add(address);
                dgvMainManageBranches.Columns.Add(totalOrderSum);
                dgvMainManageBranches.Columns.Add(revenue);
                dgvMainManageBranches.Columns["ManagerName"].Visible = false;
                dgvMainManageBranches.Columns["TotalOrderSum"].Visible = false;
                dgvMainManageBranches.Columns["Revenue"].Visible = false;
            }
        }

        private void dgvMainManageBranches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMainManageBranches.Rows.Count && e.ColumnIndex >= 0)
            {
                var branchId = dgvMainManageBranches.Rows[e.RowIndex].Cells["BranchId"].Value.ToString();
                var branchName = dgvMainManageBranches.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();
                var managerName = dgvMainManageBranches.Rows[e.RowIndex].Cells["ManagerName"].Value.ToString();
                var phone = dgvMainManageBranches.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                var address = dgvMainManageBranches.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                var totalOrderSum = dgvMainManageBranches.Rows[e.RowIndex].Cells["TotalOrderSum"].Value.ToString();
                var revenue = dgvMainManageBranches.Rows[e.RowIndex].Cells["Revenue"].Value.ToString();

                // binding 
                txtBranchId.Text = branchId;
                txtBranchName.Text = branchName;
                txtManager.Text = managerName;
                txtPhone.Text = phone;
                txtAddress.Text = address;
                txtTotalOfOrders.Text = totalOrderSum;
                txtRevenue.Text = revenue;
            }
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            MainAddBranch mainAddBranch = new MainAddBranch();
            if (mainAddBranch.ShowDialog() == DialogResult.OK)
            {
                LoadBranches();
            }
        }

        private void btnUpdateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MilkteaDBContext())
                {
                    // id name phone address
                    var branchId = 0;
                    try
                    {
                        branchId = int.Parse(txtBranchId.Text);
                        if (branchId == null)
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("BranchId is invalid.");
                    }
                    var branchName = txtBranchName.Text;
                    var phone = txtPhone.Text;
                    var address = txtAddress.Text;

                    var branch = db.Branches.SingleOrDefault(b => b.BranchId == branchId);
                    if (branch != null)
                    {
                        // update 
                        branch.BranchName = branchName;
                        branch.Phone = phone;
                        branch.Address = address;

                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Update branch success.");
                            LoadBranches();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Must not be Empty.");
                return;
            }
            LoadSearch();
        }

        // load search
        private void LoadSearch()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvMainManageBranches.AutoGenerateColumns = false;
                dgvMainManageBranches.Columns.Clear();
                dgvMainManageBranches.DataSource = null;

                var branchesList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                ManagerName = b.ManagerId,
                Phone = b.Phone,
                Address = b.Address,
                TotalOrderSum = b.Orders.Sum(o => o.Total),
                Revenue = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice)
            }).ToList();

                // sử dụng Contains
                string searchKeyword = txtSearch.Text.Trim();
                var branchesToDisplay = db.Branches.Where(b => b.BranchName.Contains(searchKeyword) | b.Phone.Contains(searchKeyword)).ToList();

                dgvMainManageBranches.DataSource = branchesToDisplay;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn branchId = new DataGridViewTextBoxColumn();
                branchId.Name = "BranchId";
                branchId.HeaderText = "Branch ID";
                branchId.DataPropertyName = "BranchId";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn managerName = new DataGridViewTextBoxColumn();
                managerName.Name = "ManagerName";
                managerName.HeaderText = "Manager Name";
                managerName.DataPropertyName = "ManagerName";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalOrderSum = new DataGridViewTextBoxColumn();
                totalOrderSum.Name = "TotalOrderSum";
                totalOrderSum.HeaderText = "Total Of Orders";
                totalOrderSum.DataPropertyName = "TotalOrderSum";

                DataGridViewTextBoxColumn revenue = new DataGridViewTextBoxColumn();
                revenue.Name = "Revenue";
                revenue.HeaderText = "Revenue";
                revenue.DataPropertyName = "Revenue";

                dgvMainManageBranches.Columns.Add(branchId);
                dgvMainManageBranches.Columns.Add(branchName);
                dgvMainManageBranches.Columns.Add(managerName);
                dgvMainManageBranches.Columns.Add(phone);
                dgvMainManageBranches.Columns.Add(address);
                dgvMainManageBranches.Columns.Add(totalOrderSum);
                dgvMainManageBranches.Columns.Add(revenue);
                dgvMainManageBranches.Columns["ManagerName"].Visible = false;
                dgvMainManageBranches.Columns["TotalOrderSum"].Visible = false;
                dgvMainManageBranches.Columns["Revenue"].Visible = false;

                branchesToDisplay.Any();

                // Hiển thị thông báo nếu không tìm thấy dữ liệu
                if (branchesToDisplay.Count == 0)
                {
                    MessageBox.Show("No Manager has UserName or Email was found.");
                    LoadBranches();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilterAddress();
        }

        // load FilterAdress
        private void LoadFilterAddress()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvMainManageBranches.AutoGenerateColumns = false;
                dgvMainManageBranches.Columns.Clear();
                dgvMainManageBranches.DataSource = null;

                var branchesList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                ManagerName = b.Accounts.FirstOrDefault(a => a.RoleId == 2).Name,
                Phone = b.Phone,
                Address = b.Address,
                TotalOrderSum = b.Orders.Sum(o => o.Total),
                Revenue = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice)
            }).ToList();

                // Lấy giá trị đã chọn từ ComboBox cbFilterAddress
                string selectedAddress = cbAddress.SelectedItem.ToString();

                // Sử dụng Where để lọc các chi nhánh có địa chỉ khớp với giá trị đã chọn
                var branchesToDisplay = db.Branches.Where(b => b.Address.Contains(selectedAddress)).ToList();

                dgvMainManageBranches.DataSource = branchesToDisplay;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn branchId = new DataGridViewTextBoxColumn();
                branchId.Name = "BranchId";
                branchId.HeaderText = "Branch ID";
                branchId.DataPropertyName = "BranchId";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn managerName = new DataGridViewTextBoxColumn();
                managerName.Name = "ManagerName";
                managerName.HeaderText = "Manager Name";
                managerName.DataPropertyName = "ManagerName";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalOrderSum = new DataGridViewTextBoxColumn();
                totalOrderSum.Name = "TotalOrderSum";
                totalOrderSum.HeaderText = "Total Of Orders";
                totalOrderSum.DataPropertyName = "TotalOrderSum";

                DataGridViewTextBoxColumn revenue = new DataGridViewTextBoxColumn();
                revenue.Name = "Revenue";
                revenue.HeaderText = "Revenue";
                revenue.DataPropertyName = "Revenue";

                dgvMainManageBranches.Columns.Add(branchId);
                dgvMainManageBranches.Columns.Add(branchName);
                dgvMainManageBranches.Columns.Add(managerName);
                dgvMainManageBranches.Columns.Add(phone);
                dgvMainManageBranches.Columns.Add(address);
                dgvMainManageBranches.Columns.Add(totalOrderSum);
                dgvMainManageBranches.Columns.Add(revenue);
                dgvMainManageBranches.Columns["ManagerName"].Visible = false;
                dgvMainManageBranches.Columns["TotalOrderSum"].Visible = false;
                dgvMainManageBranches.Columns["Revenue"].Visible = false;

                branchesToDisplay.Any();
            }
        }

        // khai báo 1 biến hiện tại
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        private bool doubleClick = false;

        // can click to object title
        private async void dgvMainManageBranches_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvMainManageBranches.Columns[e.ColumnIndex];

            // Kiểm tra xem có đúp chuột hay không
            if (doubleClick)
            {
                // Đảo ngược hướng sắp xếp khi đúp chuột
                currentSortDirection = (currentSortDirection == ListSortDirection.Ascending)
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
            else
            {
                SortData(clickedColumn);
            }

            // Đặt biến doubleClick thành true để đánh dấu lần nhấp chuột
            doubleClick = true;

            // Đợi 300ms để kiểm tra xem có phải đúp chuột hay không
            await Task.Delay(300);

            // Đặt biến doubleClick thành false sau khi đợi
            doubleClick = false;
        }

        // sort
        private void SortData(DataGridViewColumn column)
        {
            string propertyName = column.DataPropertyName;

            using (var db = new MilkteaDBContext())
            {
                List<Models.Branch> branchersToDisplay = db.Branches.ToList();

                if (currentSortDirection == ListSortDirection.Ascending)
                {
                    branchersToDisplay = branchersToDisplay.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    branchersToDisplay = branchersToDisplay.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
                dgvMainManageBranches.DataSource = branchersToDisplay;
            }
        }

        // trích xuất giá trị của một thuộc tính cụ thể từ một đối tượng bằng cách sử dụng reflection
        // reflection: tạo đối tượng, gọi phương thức
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        // paging 
        private int currentPage = 1;
        private int itemsPerPage = 5; // số lượng mỗi trang

        private void LoadBranches(int page)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalBranches = db.Branches.Count();
                var totalPages = (int)Math.Ceiling((double)totalBranches / itemsPerPage);

                if (page < 1)
                    page = 1;
                if (page > totalPages)
                    page = totalPages;

                currentPage = page;

                var branchesToDisplay = db.Branches
                    .OrderBy(b => b.BranchId)
                    .Skip((currentPage - 1) * itemsPerPage)
                    .Take(itemsPerPage)
                    .ToList();

                dgvMainManageBranches.DataSource = branchesToDisplay;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadBranches(1);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            LoadBranches(currentPage - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadBranches(currentPage + 1);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalBranches = db.Branches.Count();
                var totalPages = (int)Math.Ceiling((double)totalBranches / itemsPerPage);

                LoadBranches(totalPages);
            }
        }

        private void btnAllBranchesList_Click(object sender, EventArgs e)
        {
            LoadBranches();
            // cho việc sort khi click vào title
            dgvMainManageBranches.ColumnHeaderMouseClick += dgvMainManageBranches_ColumnHeaderMouseClick;
        }
    }
}
