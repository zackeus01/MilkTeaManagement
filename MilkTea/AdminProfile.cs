using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MilkTea.Models;

namespace MilkTea
{
    public partial class AdminProfile : Form
    {
        private int loggedInManagerId;
        Account manager;
        public AdminProfile()
        {
            InitializeComponent();
        }

        public AdminProfile(Account ac)
        {
            InitializeComponent();
            manager = ac;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {

                if (manager != null)
                {
                    string imagePath = manager.Image;
                    DisplayImageInPanel(pbAvatar, imagePath);
                }
            }

            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtReNewPass.UseSystemPasswordChar = true;
            ManagerLoad();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            ManagerLoad();
            txtNewPass.Clear();
            txtReNewPass.Clear();
        }

        private void ManagerLoad()
        {
            using (var db = new MilkteaDBContext())
            {

                if (manager != null)
                {
                    txtName.Text = manager.Name;
                    rbMale.Checked = manager.Gender == true;
                    rbFemale.Checked = manager.Gender == false;
                    dtDob.Value = manager.Dob;
                    txtPhone.Text = manager.Phone;
                    txtEmail.Text = manager.Email;
                    txtAddress.Text = manager.Address;
                    txtAccount.Text = manager.Username;
                    txtPassword.Text = manager.Password;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                // Lấy dữ liệu trên input form
                var managerName = txtName.Text;
                var manageGender = rbMale.Checked;
                var managerDob = dtDob.Value;
                var managerPhone = txtPhone.Text;
                var managerEmail = txtEmail.Text;
                var managerAddress = txtAddress.Text;

                // thực hiện update 
                if (manager != null)
                {
                    // update 
                    manager.Name = managerName;
                    manager.Gender = manageGender;
                    manager.Dob = managerDob;
                    manager.Phone = managerPhone;
                    manager.Email = managerEmail;
                    manager.Address = managerAddress;

                    // save changes 
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Update Manager success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // xem password ẩn
        private bool isPasswordVisible = true;
        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnViewNewPass_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void btnViewReBewPass_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtReNewPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtReNewPass.UseSystemPasswordChar = false;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            using (var db = new MilkteaDBContext())
            {
                // Lấy dữ liệu trên input form
                var accountName = txtAccount.Text;
                // thực hiện update 
                if (manager != null)
                {
                    // update 
                    manager.Username = accountName;

                    // save changes 
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Update Account success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private bool IsValid()
        {
            bool flag = true;
            string msg = "";

            if (txtNewPass.Text.Equals("") || txtReNewPass.Text.Equals(""))
            {
                flag = false;
                msg += "Must not be empty.\n";
            }
            else if (txtNewPass.Text != txtReNewPass.Text)
            {
                flag = false;
                msg += "Must be equal.\n";
            }
            else
            {
                return flag;
            }

            if (flag == false)
            {
                MessageBox.Show(msg);
            }
            return flag;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (var db = new MilkteaDBContext())
                {
                    // Lấy dữ liệu trên input form
                    var newPass = txtNewPass.Text;
                    var reNewPass = txtReNewPass.Text;
                    // thực hiện update
                    if (manager != null)
                    {
                        // update
                        manager.Password = newPass;

                        // save changes
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Update Password success");
                            txtNewPass.Clear();
                            txtReNewPass.Clear();
                            ManagerLoad();
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
            txtNewPass.Clear();
            txtReNewPass.Clear();
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
                    if (manager != null)
                    {
                        manager.Image = selectedImagePath;
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Image updated successfully");
                            ManagerLoad();
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

        private void btnCancelImage_Click(object sender, EventArgs e)
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
    }
}