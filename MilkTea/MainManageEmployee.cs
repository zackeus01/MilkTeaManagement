using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MilkTea
{
    public partial class MainManageEmployee : Form
    {
        public MainManageEmployee()
        {
            InitializeComponent();
        }

        private void MainManageEmployee_Load(object sender, EventArgs e)
        {
            txtEmpId.ReadOnly = true;
            LoadEmployees();
            dgvMainManageEmployee.ColumnHeaderMouseClick += dgvMainManageEmployee_ColumnHeaderMouseClick;
        }

        private void LoadEmployees()
        {
            using (var db = new MilkteaDBContext())
            {
                dgvMainManageEmployee.AutoGenerateColumns = false;
                dgvMainManageEmployee.Columns.Clear();
                dgvMainManageEmployee.DataSource = null;

                var managerList = db.Accounts
                .Where(a => a.Role.RoleId == 3)
            .Select(m => new
            {
                AccountId = m.AccountId,
                Username = m.Username,
                Password = m.Password,
                BranchName = m.BranchId,
                Name = m.Name,
                Gender = m.Gender == true ? "Male" : "Female",
                Dob = m.Dob,
                Phone = m.Phone,
                Email = m.Email,
                Address = m.Address,
                Image = m.Image,
                Role = m.Role.RoleName
            }).ToList();
                dgvMainManageEmployee.DataSource = managerList;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn accountId = new DataGridViewTextBoxColumn();
                accountId.Name = "AccountId";
                accountId.HeaderText = "Employee ID";
                accountId.DataPropertyName = "AccountId";

                DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
                username.Name = "Username";
                username.HeaderText = "User Name";
                username.DataPropertyName = "Username";

                DataGridViewTextBoxColumn password = new DataGridViewTextBoxColumn();
                password.Name = "Password";
                password.HeaderText = "Password";
                password.DataPropertyName = "Password";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                name.Name = "Name";
                name.HeaderText = "Full Name";
                name.DataPropertyName = "Name";

                DataGridViewTextBoxColumn gender = new DataGridViewTextBoxColumn();
                gender.Name = "Gender";
                gender.HeaderText = "Gender";
                gender.DataPropertyName = "Gender";

                DataGridViewTextBoxColumn dob = new DataGridViewTextBoxColumn();
                dob.Name = "Dob";
                dob.HeaderText = "Dob";
                dob.DataPropertyName = "Dob";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
                email.Name = "Email";
                email.HeaderText = "Email";
                email.DataPropertyName = "Email";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
                image.Name = "Image";
                image.HeaderText = "Image";
                image.DataPropertyName = "Image";
                //image.Visible = false; // Ẩn cột Image trong DataGridView

                DataGridViewTextBoxColumn role = new DataGridViewTextBoxColumn();
                role.Name = "Role";
                role.HeaderText = "Role";
                role.DataPropertyName = "Role";

                // thêm cột
                dgvMainManageEmployee.Columns.Add(accountId);
                dgvMainManageEmployee.Columns.Add(username);
                dgvMainManageEmployee.Columns.Add(email);
                dgvMainManageEmployee.Columns.Add(phone);
                dgvMainManageEmployee.Columns.Add(address);
                dgvMainManageEmployee.Columns.Add(password);
                dgvMainManageEmployee.Columns.Add(name);
                dgvMainManageEmployee.Columns.Add(gender);
                dgvMainManageEmployee.Columns.Add(dob);
                dgvMainManageEmployee.Columns.Add(image);
                dgvMainManageEmployee.Columns.Add(role);
                dgvMainManageEmployee.Columns.Add(branchName);
                dgvMainManageEmployee.Columns["Image"].Visible = false;
                dgvMainManageEmployee.Columns["Password"].Visible = false;
                dgvMainManageEmployee.Columns["Name"].Visible = false;
                dgvMainManageEmployee.Columns["Gender"].Visible = false;
                dgvMainManageEmployee.Columns["Dob"].Visible = false;
                dgvMainManageEmployee.Columns["Role"].Visible = false;
                dgvMainManageEmployee.Columns["BranchName"].Visible = false;
            }
        }

        private void dgvMainManageEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMainManageEmployee.Rows.Count && e.ColumnIndex >= 0)
            {
                string imagePath = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Image"].Value.ToString();
                // Gọi hàm để hiển thị hình ảnh
                DisplayImageInPanel(imagePath);

                var accountId = dgvMainManageEmployee.Rows[e.RowIndex].Cells["AccountId"].Value.ToString();
                var username = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                var password = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                var branchName = dgvMainManageEmployee.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();
                var name = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                var gender = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                var dob = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Dob"].Value.ToString();
                var phone = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                var email = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var address = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                var role = dgvMainManageEmployee.Rows[e.RowIndex].Cells["Role"].Value.ToString();

                // binding
                txtEmpId.Text = accountId;
                txtUsername.Text = username;
                txtPassword.Text = password;
                txtBranch.Text = branchName;
                txtName.Text = name;
                if (gender.Equals("Male")) rbMale.Checked = true;
                else rbFemale.Checked = true;
                dtDob.Text = dob;
                txtPhone.Text = phone;
                txtEmail.Text = email;
                txtAddress.Text = address;
            }
        }

        // pbAvatar
        private void DisplayImageInPanel(string imagePath)
        {
            // ?
            byte[] imageData = File.ReadAllBytes(imagePath);
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }

            pbAvatar.BackgroundImage = image;
            // Thay đổi kiểu hiển thị hình ảnh
            pbAvatar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            MainAddEmployee mainAddEmployee = new MainAddEmployee();
            if (mainAddEmployee.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
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
                dgvMainManageEmployee.AutoGenerateColumns = false;
                dgvMainManageEmployee.Columns.Clear();
                dgvMainManageEmployee.DataSource = null;

                // Tạo mới 1 danh sách các Anonymous object lấy dữ liệu từ List<Manager>
                var managerList = db.Accounts.Where(a => a.RoleId == 2)
            .Select(m => new
            {
                AccountId = m.AccountId,
                Username = m.Username,
                Password = m.Password,
                BranchName = m.BranchId, // BranchName
                Name = m.Name,
                Gender = m.Gender == true ? "Male" : "Female",
                Dob = m.Dob,
                Phone = m.Phone,
                Email = m.Email,
                Address = m.Address,
                Image = m.Image,
                Role = m.RoleId //role name
            })
            .ToList();

                // sử dụng Contains
                string searchKeyword = txtSearch.Text.Trim();
                var managersToDisplay = db.Accounts.Where(a => a.Username.Contains(searchKeyword) | a.Email.Contains(searchKeyword)).Where(a => a.RoleId == 3).ToList();

                dgvMainManageEmployee.DataSource = managersToDisplay;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn accountId = new DataGridViewTextBoxColumn();
                accountId.Name = "AccountId";
                accountId.HeaderText = "Manager ID";
                accountId.DataPropertyName = "AccountId";

                DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
                username.Name = "Username";
                username.HeaderText = "User Name";
                username.DataPropertyName = "Username";

                DataGridViewTextBoxColumn password = new DataGridViewTextBoxColumn();
                password.Name = "Password";
                password.HeaderText = "Password";
                password.DataPropertyName = "Password";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                name.Name = "Name";
                name.HeaderText = "Full Name";
                name.DataPropertyName = "Name";

                DataGridViewTextBoxColumn gender = new DataGridViewTextBoxColumn();
                gender.Name = "Gender";
                gender.HeaderText = "Gender";
                gender.DataPropertyName = "Gender";

                DataGridViewTextBoxColumn dob = new DataGridViewTextBoxColumn();
                dob.Name = "Dob";
                dob.HeaderText = "Dob";
                dob.DataPropertyName = "Dob";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
                email.Name = "Email";
                email.HeaderText = "Email";
                email.DataPropertyName = "Email";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
                image.Name = "Image";
                image.HeaderText = "Image";
                image.DataPropertyName = "Image";
                //image.Visible = false; // Ẩn cột Image trong DataGridView

                //DataGridViewTextBoxColumn role = new DataGridViewTextBoxColumn();
                //role.Name = "Role";
                //role.HeaderText = "Role";
                //role.DataPropertyName = "Role";


                dgvMainManageEmployee.Columns.Add(accountId);
                dgvMainManageEmployee.Columns.Add(username);
                dgvMainManageEmployee.Columns.Add(email);
                dgvMainManageEmployee.Columns.Add(phone);
                dgvMainManageEmployee.Columns.Add(address);
                dgvMainManageEmployee.Columns.Add(password);
                dgvMainManageEmployee.Columns.Add(name);
                dgvMainManageEmployee.Columns.Add(gender);
                dgvMainManageEmployee.Columns.Add(dob);
                dgvMainManageEmployee.Columns.Add(image);
                //dgvMainManageAdmin.Columns.Add(role);
                dgvMainManageEmployee.Columns.Add(branchName);
                dgvMainManageEmployee.Columns["Image"].Visible = false;
                dgvMainManageEmployee.Columns["Password"].Visible = false;
                dgvMainManageEmployee.Columns["Name"].Visible = false;
                dgvMainManageEmployee.Columns["Gender"].Visible = false;
                dgvMainManageEmployee.Columns["Dob"].Visible = false;
                //dgvMainManageAdmin.Columns["Role"].Visible = false;
                //dgvMainManageAdmin.Columns["BranchName"].Visible = false;

                managersToDisplay.Any();

                // Hiển thị thông báo nếu không tìm thấy dữ liệu
                if (managersToDisplay.Count == 0)
                {
                    MessageBox.Show("No Manager has UserName or Email was found.");
                    LoadEmployees();
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
                dgvMainManageEmployee.AutoGenerateColumns = false;
                dgvMainManageEmployee.Columns.Clear();
                dgvMainManageEmployee.DataSource = null;

                // Tạo mới 1 danh sách các Anonymous object lấy dữ liệu từ List<Manager>
                var managerList = db.Accounts.Where(a => a.RoleId == 3)
            .Select(m => new
            {
                AccountId = m.AccountId,
                Username = m.Username,
                Password = m.Password,
                BranchName = m.BranchId, // BranchName
                Name = m.Name,
                Gender = m.Gender == true ? "Male" : "Female",
                Dob = m.Dob,
                Phone = m.Phone,
                Email = m.Email,
                Address = m.Address,
                Image = m.Image,
                Role = m.RoleId //role name
            })
            .ToList();

                // Lấy giá trị đã chọn từ ComboBox cbFilterAddress
                string selectedAddress = cbAddress.SelectedItem.ToString();

                // Sử dụng Where để lọc các chi nhánh có địa chỉ khớp với giá trị đã chọn
                var managersToDisplay = db.Accounts.Where(b => b.Address.Contains(selectedAddress) && b.RoleId == 3).ToList();

                dgvMainManageEmployee.DataSource = managersToDisplay;

                // tổ chức các cột cho datagridview theo yêu cầu 
                DataGridViewTextBoxColumn accountId = new DataGridViewTextBoxColumn();
                accountId.Name = "AccountId";
                accountId.HeaderText = "Manager ID";
                accountId.DataPropertyName = "AccountId";

                DataGridViewTextBoxColumn username = new DataGridViewTextBoxColumn();
                username.Name = "Username";
                username.HeaderText = "User Name";
                username.DataPropertyName = "Username";

                DataGridViewTextBoxColumn password = new DataGridViewTextBoxColumn();
                password.Name = "Password";
                password.HeaderText = "Password";
                password.DataPropertyName = "Password";

                DataGridViewTextBoxColumn branchName = new DataGridViewTextBoxColumn();
                branchName.Name = "BranchName";
                branchName.HeaderText = "Branch Name";
                branchName.DataPropertyName = "BranchName";

                DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
                name.Name = "Name";
                name.HeaderText = "Full Name";
                name.DataPropertyName = "Name";

                DataGridViewTextBoxColumn gender = new DataGridViewTextBoxColumn();
                gender.Name = "Gender";
                gender.HeaderText = "Gender";
                gender.DataPropertyName = "Gender";

                DataGridViewTextBoxColumn dob = new DataGridViewTextBoxColumn();
                dob.Name = "Dob";
                dob.HeaderText = "Dob";
                dob.DataPropertyName = "Dob";

                DataGridViewTextBoxColumn phone = new DataGridViewTextBoxColumn();
                phone.Name = "Phone";
                phone.HeaderText = "Phone";
                phone.DataPropertyName = "Phone";

                DataGridViewTextBoxColumn email = new DataGridViewTextBoxColumn();
                email.Name = "Email";
                email.HeaderText = "Email";
                email.DataPropertyName = "Email";

                DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
                address.Name = "Address";
                address.HeaderText = "Address";
                address.DataPropertyName = "Address";

                DataGridViewTextBoxColumn image = new DataGridViewTextBoxColumn();
                image.Name = "Image";
                image.HeaderText = "Image";
                image.DataPropertyName = "Image";
                //image.Visible = false; // Ẩn cột Image trong DataGridView

                //DataGridViewTextBoxColumn role = new DataGridViewTextBoxColumn();
                //role.Name = "Role";
                //role.HeaderText = "Role";
                //role.DataPropertyName = "Role";


                dgvMainManageEmployee.Columns.Add(accountId);
                dgvMainManageEmployee.Columns.Add(username);
                dgvMainManageEmployee.Columns.Add(email);
                dgvMainManageEmployee.Columns.Add(phone);
                dgvMainManageEmployee.Columns.Add(address);
                dgvMainManageEmployee.Columns.Add(password);
                dgvMainManageEmployee.Columns.Add(name);
                dgvMainManageEmployee.Columns.Add(gender);
                dgvMainManageEmployee.Columns.Add(dob);
                dgvMainManageEmployee.Columns.Add(image);
                //dgvMainManageAdmin.Columns.Add(role);
                dgvMainManageEmployee.Columns.Add(branchName);
                dgvMainManageEmployee.Columns["Image"].Visible = false;
                dgvMainManageEmployee.Columns["Password"].Visible = false;
                dgvMainManageEmployee.Columns["Name"].Visible = false;
                dgvMainManageEmployee.Columns["Gender"].Visible = false;
                dgvMainManageEmployee.Columns["Dob"].Visible = false;
                //dgvMainManageAdmin.Columns["Role"].Visible = false;
                //dgvMainManageAdmin.Columns["BranchName"].Visible = false;

                managersToDisplay.Any();
            }
        }

        // paging 
        private int currentPage = 1;
        private int itemsPerPage = 5; // số lượng mỗi trang

        private void LoadEmployees(int page)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalManagers = db.Accounts.Count();
                var totalPages = (int)Math.Ceiling((double)totalManagers / itemsPerPage);

                if (page < 1)
                    page = 1;
                if (page > totalPages)
                    page = totalPages;

                currentPage = page;

                // Calculate the number of items to skip and take for the current page
                int itemsToSkip = (currentPage - 1) * itemsPerPage;
                int itemsToTake = itemsPerPage;

                var managersToDisplay = db.Accounts
                    .Where(a => a.RoleId == 3)
                    .OrderBy(a => a.AccountId) // You might need to order the items
                    .Skip(itemsToSkip)
                    .Take(itemsToTake)
                    .Select(a => new
                    {
                        a.AccountId,
                        a.Username,
                        a.Email,
                        a.Phone,
                        a.Address
                    })
                    .ToList();

                dgvMainManageEmployee.DataSource = managersToDisplay;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadEmployees(1);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            LoadEmployees(currentPage - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadEmployees(currentPage + 1);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                var totalManager = db.Accounts.Count();
                var totalPages = (int)Math.Ceiling((double)totalManager / itemsPerPage);

                LoadEmployees(totalPages);
            }
        }

        private void btnAllEmployeeList_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        // khai báo 1 biến hiện tại
        private ListSortDirection currentSortDirection = ListSortDirection.Ascending;
        private bool doubleClick = false;

        // can click to object title
        private async void dgvMainManageEmployee_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvMainManageEmployee.Columns[e.ColumnIndex];

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
                List<Account> managersToDisplay = db.Accounts.Where(a => a.RoleId == 3).ToList();

                if (currentSortDirection == ListSortDirection.Ascending)
                {
                    managersToDisplay = managersToDisplay.OrderBy(x => GetPropertyValue(x, propertyName)).ToList();
                }
                else
                {
                    managersToDisplay = managersToDisplay.OrderByDescending(x => GetPropertyValue(x, propertyName)).ToList();
                }
                dgvMainManageEmployee.DataSource = managersToDisplay;
            }
        }

        // trích xuất giá trị của một thuộc tính cụ thể từ một đối tượng bằng cách sử dụng reflection
        // reflection: tạo đối tượng, gọi phương thức
        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        // trống để lấy dường dẫn
        private string selectedImagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    DisplayImageInPanel(pbReview, selectedImagePath);
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                using (var db = new MilkteaDBContext())
                {
                    var manager = db.Accounts.FirstOrDefault(m => m.RoleId == 3);
                    if (manager != null)
                    {
                        manager.Image = selectedImagePath;
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Image updated successfully");
                            LoadEmployees();
                            DisplayImageInPanel(pbAvatar, selectedImagePath); // Update the main avatar image too
                            pbReview.BackgroundImage = null; // Clear the preview
                            selectedImagePath = ""; // Reset the selected image path
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedImagePath = ""; // làm trống đường dẫn được chọn
            pbReview.BackgroundImage = null; // xóa cho = null
        }

        private void DisplayImageInPanel(Panel pbAvatar, string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        pbAvatar.BackgroundImage = image;
                        pbAvatar.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
                else
                {
                    pbAvatar.BackgroundImage = null; // Clear the image if the file doesn't exist
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                if (int.TryParse(txtEmpId.Text, out int managerId))
                {
                    var manager = db.Accounts.SingleOrDefault(a => a.AccountId == managerId && a.RoleId == 3);

                    if (manager != null)
                    {
                        try
                        {
                            manager.Username = txtUsername.Text;
                            manager.Password = txtPassword.Text;
                            manager.Name = txtName.Text;
                            manager.Phone = txtPhone.Text;
                            manager.Email = txtEmail.Text;
                            manager.Address = txtAddress.Text;
                            manager.Gender = rbMale.Checked;
                            manager.Dob = dtDob.Value;

                            db.SaveChanges();
                            MessageBox.Show("Update employee success.");
                            LoadEmployees();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Manager not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Manager ID. Please enter a valid integer value.");
                }
            }
        }

        private void btnUpgraded_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEmpId.Text, out int employeeId))
            {
                using (var db = new MilkteaDBContext())
                {
                    var employee = db.Accounts.SingleOrDefault(a => a.AccountId == employeeId && a.RoleId == 3);

                    if (employee != null)
                    {
                        employee.RoleId = 2;

                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Employee upgraded to Manager successfully.");
                            LoadEmployees();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Employee ID.");
            }

        }

        private void btnLayoff_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEmpId.Text, out int employeeId))
            {
                using (var db = new MilkteaDBContext())
                {
                    var employee = db.Accounts.SingleOrDefault(a => a.AccountId == employeeId && a.RoleId == 3);

                    if (employee != null)
                    {
                        db.Accounts.Remove(employee);

                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Employee is out of company MilkTea.");
                            LoadEmployees();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Manager not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Employee ID.");
            }
        }

    }
}
