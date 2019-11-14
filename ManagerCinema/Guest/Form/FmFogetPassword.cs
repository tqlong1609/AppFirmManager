using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using ManagerCinema.BSLayer;

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
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("17110313@student.hcmute.edu.vn", "k16111999");
            try{
                client.Send(mess);
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to connect");
            }
        }
        int New_Password;
        string Gmail;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = bunifuMetroTextbox3.Text;
            ForgetPasswordBS = new ForgetPasswordBS();
            Gmail = ForgetPasswordBS.Send_Mail_To(Username);
            Random rd = new Random();
            New_Password = rd.Next(100000, 9999999);
            ForgetPasswordBS.Change_Password(Username, New_Password.ToString());
            try
            {
                threadEmail = new Thread(sendEmail);
                threadEmail.SetApartmentState(ApartmentState.STA);
                threadEmail.Start();
                MessageBox.Show("Send new password success in your email");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connect");
            }
            //this.Close();
        }

        private void sendEmail()
        {
            GuiMail("17110313@student.hcmute.edu.vn", Gmail, "Reset Password", "Mật khẩu mới của bạn là: " + New_Password);
        }
    }
}
