using MilkTea.Models;
using System.Net.Mail;

namespace MilkTea
{

    public partial class ForgotPassword : Form
    {
        private readonly MilkteaDBContext db = new MilkteaDBContext();
        public ForgotPassword()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        string otp;
        private string username;
        private string email;

        private static readonly string _to = "tungdqhe161511@fpt.edu.vn";
        private static readonly string _passto = "eujdtujrjpfzcrup";
        private static readonly string _from = "tung2832002@gmail.com";
        private static readonly string _pass = "kbwztyaqcqshvngy";
        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            email = txtEmail.Text;

            if (username.StartsWith("admin"))
            {
                try
                {

                    otp = rd.Next(100000, 999999).ToString();
                    string username = txtUsername.Text;

                    var user = db.Accounts.FirstOrDefault(x => x.Username == username);
                    if (user == null)
                    {
                        MessageBox.Show("Try again ,please enter correct information");
                        return;
                    }
                    if (email != _to || email == null)
                    {

                        MessageBox.Show("Try again ,please enter correct information");
                        return;
                    }



                    MailMessage mail = new MailMessage();

                    mail.From = new MailAddress(_from);
                    mail.To.Add(_to);
                    mail.Subject = "OTP";
                    mail.IsBodyHtml = true;
                    mail.Body = otp.ToString();



                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential(_from, _pass);
                    smtp.EnableSsl = true;


                    smtp.Send(mail);
                    MessageBox.Show("OTP đã được gửi");




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Please enter admin account");
            }




        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            email = txtEmail.Text;
            var user = db.Accounts.FirstOrDefault(x => x.Username == username);
            if (username == null || email.ToString() == null)
            {
                MessageBox.Show("Please enter your username and email");
                return;
            }
            if (user == null)
            {
                MessageBox.Show("Username is incorrect");
                return;
            }


            if (email != _to)
            {

                MessageBox.Show("Email is incorrect");
                return;
            }


            string enteredOTP = txtOTP.Text;
            if (enteredOTP == null)
            {
                MessageBox.Show("Please enter OTP");
                return;
            }
            if (enteredOTP == otp)
            {
                // OTP đúng
                MessageBox.Show("OTP is correct");

                ChangePassword formChangePassword = new ChangePassword(); // Tạo và hiển thị form ChangePassword
                formChangePassword.Show();
                this.Hide();

            }
            else
            {
                // OTP sai
                MessageBox.Show("OTP is incorrect");

                // Xử lý khi OTP sai (ví dụ: thông báo cho người dùng nhập lại OTP)
                return;
            }



        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}