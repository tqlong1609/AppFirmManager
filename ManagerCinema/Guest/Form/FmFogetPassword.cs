using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using ManagerCinema.BSLayer;
using System.Text.RegularExpressions;

namespace ManagerCinema
{
    public partial class FmFogetPassword : FormMain
    {
        // thread handle open new form
        private Thread threadForm;
        private Thread threadEmail;
        private ForgetPasswordBS ForgetPasswordBS;
        public FmFogetPassword()
        {
            InitializeComponent();
        }

        private void FmFogetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmFogetPassword_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmFogetPassword_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // open new form
            this.Close();
            threadForm = new Thread(openFormLogin);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormLogin()
        {
            Application.Run(new FmLogin());
        }

        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            if (to == "")
            {
                MessageBox.Show("Your Gmail is not exsit!");
                return;
            }
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("17110313@student.hcmute.edu.vn", "k16111999");
            try
            {
                client.Send(mess);
                MessageBox.Show("Send new password success in your email");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect");
            }
        }

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }


        int New_Password;
        string Gmail;
        string Destination_Gmail;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Destination_Gmail = bunifuMetroTextbox3.Text;
            if (!isEmail(Destination_Gmail))
            {
                MessageBox.Show("Your Gmail is not in the right format, please try again");
                return;
            }

            ForgetPasswordBS = new ForgetPasswordBS();
            Gmail = ForgetPasswordBS.Send_Mail_To(Destination_Gmail);
            Random rd = new Random();
            New_Password = rd.Next(100000, 9999999);
            ForgetPasswordBS.Change_Password(Destination_Gmail, New_Password.ToString());
            try
            {
                threadEmail = new Thread(sendEmail);
                threadEmail.SetApartmentState(ApartmentState.STA);
                threadEmail.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect");
            }
        }

        private void sendEmail()
        {
            GuiMail("17110313@student.hcmute.edu.vn", Destination_Gmail, "Reset Password", "Mật khẩu mới của bạn là: " + New_Password);
        }
    }
}
