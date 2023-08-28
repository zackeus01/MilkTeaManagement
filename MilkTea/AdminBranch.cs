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
using System.Xml.Linq;

namespace MilkTea
{
    public partial class AdminBranch : Form
    {
        public AdminBranch()
        {
            InitializeComponent();
        }

        private void AdminBranch_Load(object sender, EventArgs e)
        {
            LoadBranches(currentPage);
            dgvAdminBranch.ColumnHeaderMouseClick += dgvAdminBranch_ColumnHeaderMouseClick;
            if (cbFilterAddress.Items.Count > 0)
            {
                cbFilterAddress.SelectedIndex = 0;
            }
            if (cbFilterPhone.Items.Count > 0)
            {
                cbFilterPhone.SelectedIndex = 0;
            }
            txtMyManagerName.ReadOnly = true;
            txtManager.ReadOnly = true;
            txtBranchName.ReadOnly = true;
            txtBranchPhone.ReadOnly = true;
            txtBranchAddress.ReadOnly = true;
            txtBranchRevenue.ReadOnly = true;
            LoadMyManagerName();
            LoadMyBranches();
            LoadBranches();
        }

        private void LoadMyBranches()
        {
            using (var db = new MilkteaDBContext())
            {
                var branch = db.Branches.FirstOrDefault(b => b.BranchId == 1);
                txtMyBranchName.Text = branch.BranchName;
                txtMyBranchPhone.Text = branch.Phone;
                txtMyBranchAddress.Text = branch.Address;
            }
        }

        private void LoadMyManagerName()
        {
            using (var db = new MilkteaDBContext())
            {
                var manager = db.Accounts.FirstOrDefault();
                txtMyManagerName.Text = manager.Username;
            }
        }

        // load banches
        private void LoadBranches()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAdminBranch.AutoGenerateColumns = false;
                dgvAdminBranch.Columns.Clear();
                dgvAdminBranch.DataSource = null;

                var adminBranchList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                Phone = b.Phone,
                Address = b.Address,
                TotalPriceSum = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice),
                ManagerName = b.ManagerId
            })
            .ToList();

                dgvAdminBranch.DataSource = adminBranchList;

                // tổ chức các cột cho datagrid view theo yêu cầu bài toán 
                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn branchPhone = new DataGridViewTextBoxColumn();
                branchPhone.Name = "BranchPhone";
                branchPhone.HeaderText = "Branch Phone";
                branchPhone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn branchAddress = new DataGridViewTextBoxColumn();
                branchAddress.Name = "BranchAddress";
                branchAddress.HeaderText = "Branch Address";
                branchAddress.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalPriceSum = new DataGridViewTextBoxColumn();
                totalPriceSum.Name = "TotalPriceSum";
                totalPriceSum.HeaderText = "Revenue";
                totalPriceSum.DataPropertyName = "TotalPriceSum";

                DataGridViewTextBoxColumn branchManager = new DataGridViewTextBoxColumn();
                branchManager.Name = "ManagerName";
                branchManager.HeaderText = "Manager";
                branchManager.DataPropertyName = "ManagerName";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAdminBranch.Columns.Add(branchName);
                dgvAdminBranch.Columns.Add(branchPhone);
                dgvAdminBranch.Columns.Add(branchAddress);
                dgvAdminBranch.Columns.Add(totalPriceSum);
                dgvAdminBranch.Columns.Add(branchManager);
                dgvAdminBranch.Columns["TotalPriceSum"].Visible = false;
                dgvAdminBranch.Columns["ManagerName"].Visible = false;
            }
        }

        private void dgvAdminBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAdminBranch.Rows.Count && e.ColumnIndex >= 0)
            {
                var branchName = dgvAdminBranch.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();
                var phone = dgvAdminBranch.Rows[e.RowIndex].Cells["BranchPhone"].Value.ToString();
                var address = dgvAdminBranch.Rows[e.RowIndex].Cells["BranchAddress"].Value.ToString();
                var totalPrice = dgvAdminBranch.Rows[e.RowIndex].Cells["TotalPriceSum"].Value.ToString();
                var managerName = dgvAdminBranch.Rows[e.RowIndex].Cells["ManagerName"].Value.ToString();

                // binding du lieu 
                txtBranchName.Text = branchName;
                txtBranchPhone.Text = phone;
                txtBranchAddress.Text = address;
                txtBranchRevenue.Text = totalPrice;
                txtManager.Text = managerName;
            }
        }

        // list all branches
        private void btnAllBranches_Click(object sender, EventArgs e)
        {
            LoadBranches();
        }

        // search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Must not be Empty.");
                return;
            }
            loadSearch();
        }

        // load search
        private void loadSearch()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAdminBranch.AutoGenerateColumns = false;
                dgvAdminBranch.Columns.Clear();
                dgvAdminBranch.DataSource = null;

                // Tạo mới 1 danh sách các Anonymous object lấy dữ liệu từ List<Branch>
                var adminBranchList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                Phone = b.Phone,
                Address = b.Address,
                TotalPriceSum = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice),
                ManagerName = b.ManagerId
            })
            .ToList();

                // sử dụng Contains
                string searchKeyword = txtSearch.Text.Trim();
                var branchesToDisplay = db.Branches.Where(b => b.BranchName.Contains(searchKeyword) | b.Phone.Contains(searchKeyword) | b.Address.Contains(searchKeyword)).ToList();

                dgvAdminBranch.DataSource = branchesToDisplay;

                // Tổ chức các cột cho DataGrid theo yêu cầu của bài toán
                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn branchPhone = new DataGridViewTextBoxColumn();
                branchPhone.Name = "BranchPhone";
                branchPhone.HeaderText = "Branch Phone";
                branchPhone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn branchAddress = new DataGridViewTextBoxColumn();
                branchAddress.Name = "BranchAddress";
                branchAddress.HeaderText = "Branch Address";
                branchAddress.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalPriceSum = new DataGridViewTextBoxColumn();
                totalPriceSum.Name = "TotalPriceSum";
                totalPriceSum.HeaderText = "Revenue";
                totalPriceSum.DataPropertyName = "TotalPriceSum";

                DataGridViewTextBoxColumn branchManager = new DataGridViewTextBoxColumn();
                branchManager.Name = "ManagerName";
                branchManager.HeaderText = "Manager";
                branchManager.DataPropertyName = "ManagerName";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAdminBranch.Columns.Add(branchName);
                dgvAdminBranch.Columns.Add(branchPhone);
                dgvAdminBranch.Columns.Add(branchAddress);
                dgvAdminBranch.Columns.Add(totalPriceSum);
                dgvAdminBranch.Columns.Add(branchManager);
                dgvAdminBranch.Columns["TotalPriceSum"].Visible = false;
                dgvAdminBranch.Columns["ManagerName"].Visible = false;

                branchesToDisplay.Any();

                // Hiển thị thông báo nếu không tìm thấy dữ liệu
                if (branchesToDisplay.Count == 0)
                {
                    MessageBox.Show("No Branches found.");
                }
            }
        }

        private void btnFilterAddress_Click(object sender, EventArgs e)
        {
            loadFilterAddress();
        }

        // load FilterAdress
        private void loadFilterAddress()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAdminBranch.AutoGenerateColumns = false;
                dgvAdminBranch.Columns.Clear();
                dgvAdminBranch.DataSource = null;

                // Tạo mới 1 danh sách các Anonymous object lấy dữ liệu từ List<Branch>
                var adminBranchList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                Phone = b.Phone,
                Address = b.Address,
                TotalOrderSum = b.Orders.Sum(o => o.Total),
                TotalPriceSum = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice),
                ManagerName = b.Accounts.Where(a => a.RoleId == 2).Select(a => a.Name)
            })
            .ToList();

                // Lấy giá trị đã chọn từ ComboBox cbFilterAddress
                string selectedAddress = cbFilterAddress.SelectedItem.ToString();

                // Sử dụng Where để lọc các chi nhánh có địa chỉ khớp với giá trị đã chọn
                var branchesToDisplay = db.Branches.Where(b => b.Address.Contains(selectedAddress)).ToList();

                dgvAdminBranch.DataSource = branchesToDisplay;

                // Tổ chức các cột cho DataGrid theo yêu cầu của bài toán
                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn branchPhone = new DataGridViewTextBoxColumn();
                branchPhone.Name = "BranchPhone";
                branchPhone.HeaderText = "Branch Phone";
                branchPhone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn branchAddress = new DataGridViewTextBoxColumn();
                branchAddress.Name = "BranchAddress";
                branchAddress.HeaderText = "Branch Address";
                branchAddress.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalOrderSum = new DataGridViewTextBoxColumn();
                totalOrderSum.Name = "TotalOrderSum";
                totalOrderSum.HeaderText = "Revenue";
                totalOrderSum.DataPropertyName = "TotalOrderSum";

                DataGridViewTextBoxColumn totalPriceSum = new DataGridViewTextBoxColumn();
                totalPriceSum.Name = "TotalPriceSum";
                totalPriceSum.HeaderText = "Revenue";
                totalPriceSum.DataPropertyName = "TotalPriceSum";

                DataGridViewTextBoxColumn branchManager = new DataGridViewTextBoxColumn();
                branchManager.Name = "ManagerName";
                branchManager.HeaderText = "Manager";
                branchManager.DataPropertyName = "ManagerName";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAdminBranch.Columns.Add(branchName);
                dgvAdminBranch.Columns.Add(branchPhone);
                dgvAdminBranch.Columns.Add(branchAddress);
                dgvAdminBranch.Columns.Add(totalOrderSum);
                dgvAdminBranch.Columns.Add(totalPriceSum);
                dgvAdminBranch.Columns.Add(branchManager);
                dgvAdminBranch.Columns["TotalOrderSum"].Visible = false;
                dgvAdminBranch.Columns["ManagerName"].Visible = false;

                branchesToDisplay.Any();
            }
        }

        private void btnFilterPhone_Click(object sender, EventArgs e)
        {
            loadFilterPhone();
        }

        // load Filter Phone
        private void loadFilterPhone()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvAdminBranch.AutoGenerateColumns = false;
                dgvAdminBranch.Columns.Clear();
                dgvAdminBranch.DataSource = null;

                // Tạo mới 1 danh sách các Anonymous object lấy dữ liệu từ List<Branch>
                var adminBranchList = db.Branches
            .Select(b => new
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                Phone = b.Phone,
                Address = b.Address,
                TotalOrderSum = b.Orders.Sum(o => o.Total),
                TotalPriceSum = b.Orders.SelectMany(o => o.OrderDetails).Sum(od => od.TotalPrice),
                ManagerName = b.ManagerId
            })
            .ToList();

                // Lấy giá trị đã chọn từ ComboBox cbFilterAddress
                string selectedPhone = cbFilterPhone.SelectedItem.ToString();

                // Sử dụng Where để lọc các chi nhánh có địa chỉ khớp với giá trị đã chọn
                var branchesToDisplay = db.Branches.Where(b => b.Phone.Contains(selectedPhone)).ToList();

                dgvAdminBranch.DataSource = branchesToDisplay;

                // Tổ chức các cột cho DataGrid theo yêu cầu của bài toán
                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn branchPhone = new DataGridViewTextBoxColumn();
                branchPhone.Name = "BranchPhone";
                branchPhone.HeaderText = "Branch Phone";
                branchPhone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn branchAddress = new DataGridViewTextBoxColumn();
                branchAddress.Name = "BranchAddress";
                branchAddress.HeaderText = "Branch Address";
                branchAddress.DataPropertyName = "Address";

                DataGridViewTextBoxColumn totalOrderSum = new DataGridViewTextBoxColumn();
                totalOrderSum.Name = "TotalOrderSum";
                totalOrderSum.HeaderText = "Revenue";
                totalOrderSum.DataPropertyName = "TotalOrderSum";

                DataGridViewTextBoxColumn totalPriceSum = new DataGridViewTextBoxColumn();
                totalPriceSum.Name = "TotalPriceSum";
                totalPriceSum.HeaderText = "Revenue";
                totalPriceSum.DataPropertyName = "TotalPriceSum";

                DataGridViewTextBoxColumn branchManager = new DataGridViewTextBoxColumn();
                branchManager.Name = "ManagerName";
                branchManager.HeaderText = "Manager";
                branchManager.DataPropertyName = "ManagerName";

                // bổ sung lần lượt các cột vào Datagridview
                dgvAdminBranch.Columns.Add(branchName);
                dgvAdminBranch.Columns.Add(branchPhone);
                dgvAdminBranch.Columns.Add(branchAddress);
                dgvAdminBranch.Columns.Add(totalOrderSum);
                dgvAdminBranch.Columns.Add(totalPriceSum);
                dgvAdminBranch.Columns.Add(branchManager);
                dgvAdminBranch.Columns["TotalOrderSum"].Visible = false;
                dgvAdminBranch.Columns["ManagerName"].Visible = false;

                branchesToDisplay.Any();
            }
        }

        // khai báo 1 biến hiện tại
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        private bool doubleClick = false;

        // sort click title cho order -> defect 
        private async void dgvAdminBranch_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvAdminBranch.Columns[e.ColumnIndex];

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

        private void SortData(DataGridViewColumn column)
        {
            string propertyName = column.DataPropertyName;

            using (var db = new MilkteaDBContext())
            {

                List<Branch> branchesToDisplay = db.Branches.ToList();

                if (currentSortDirection == ListSortDirection.Ascending)
                {
                    branchesToDisplay = branchesToDisplay.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    branchesToDisplay = branchesToDisplay.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
                dgvAdminBranch.DataSource = branchesToDisplay;
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
        private int itemsPerPage = 10; // số lượng mỗi trang

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

                dgvAdminBranch.DataSource = branchesToDisplay;
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
    }
}

// cách 2 để check từng empty 
//private void btnUpdate_Click(object sender, EventArgs e)
//{
//    TextBox selectedTextbox = this.ActiveControl as TextBox;

//    if (selectedTextbox == null ||
//        (selectedTextbox != txtMyBranchName &&
//         selectedTextbox != txtMyBranchPhone &&
//         selectedTextbox != txtMyBranchAddress))
//    {
//        MessageBox.Show("Please select a valid textbox to update.");
//        return;
//    }

//    using (var db = new MilkteaDBContext())
//    {
//        if (selectedTextbox == txtMyBranchName)
//        {
//            // Update BranchName
//        }
//        else if (selectedTextbox == txtMyBranchPhone)
//        {
//            // Update Phone
//        }
//        else if (selectedTextbox == txtMyBranchAddress)
//        {
//            // Update Address
//        }

//        try
//        {
//            db.SaveChanges();
//            MessageBox.Show("Update success");
//            LoadBranches();
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show(ex.Message);
//        }
//    }
//}

//private void btnUpdate_Click(object sender, EventArgs e)
//{
//    using (var db = new MilkteaDBContext())
//    {
//        // Lấy dữ liệu trên input form
//        var myBranchName = txtMyBranchName.Text;
//        var myBranchPhone = txtMyBranchPhone.Text;
//        var myBranchAddress = txtMyBranchAddress.Text;

//        // thực hiện update 
//        var myBranch = db.Branches.SingleOrDefault();
//        if (myBranch != null)
//        {
//            // update 
//            myBranch.BranchName = myBranchName;
//            myBranch.Phone = myBranchPhone;
//            myBranch.Address = myBranchAddress;

//            // save changes 
//            try
//            {
//                db.SaveChanges();
//                MessageBox.Show("Update Branch success");
//                LoadBranches();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }
//    }
//}