using ClosedXML.Excel;
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
    public partial class MainAddManager : Form
    {
        public MainAddManager()
        {
            InitializeComponent();
        }

        private void MainAddManager_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    using (var db = new MilkteaDBContext())
                    {
                        var newManager = new Account
                        {
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            RoleId = 2,// manager roleid = 2
                            BranchId = int.Parse(txtBranchId.Text),
                            Name = txtName.Text,
                            Gender = rbMale.Checked == true ? true : false,
                            Dob = dtDob.Value,
                            Phone = txtPhone.Text,
                            Email = txtEmail.Text,
                            Address = txtAddress.Text,
                            Image = selectedImagePath
                        };

                        db.Accounts.Add(newManager);
                        db.SaveChanges();

                        MessageBox.Show("New manager is added success.");

                        // đóng forrm
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // lấy 1 đường dẫn 
        private string selectedImagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    DisplayImageInPanel(pbAvatar, selectedImagePath);
                }
            }
        }

        private void btnCancelbrowse_Click(object sender, EventArgs e)
        {
            selectedImagePath = ""; // làm trống đường dẫn được chọn
            panel.BackgroundImage = null; // xóa cho = null
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
                    pbAvatar.BackgroundImage = null; // clear nếu file ảnh k tồn tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValid()
        {
            bool isValid = true;
            string errorMsg = "";

            // Kiểm tra ngày sinh hợp lệ
            DateTime currentDate = DateTime.Now;
            DateTime dob = dtDob.Value;
            TimeSpan age = currentDate - dob;
            int years = (int)(age.Days / 365.25);

            if (years < 18)
            {
                isValid = false;
                errorMsg += "Age must be at least 18 years old.\n";
            }

            // Kiểm tra định dạng email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                isValid = false;
                errorMsg += "Invalid email format yourname@gmail.com.\n";
            }

            // Kiểm tra số điện thoại có 10 chữ số
            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
            {
                isValid = false;
                errorMsg += "Phone number must have exactly 10 digits.\n";
            }

            if (!isValid)
            {
                MessageBox.Show(errorMsg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }
    }
}