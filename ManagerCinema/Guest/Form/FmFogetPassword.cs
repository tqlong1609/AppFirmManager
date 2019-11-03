using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ManagerCinema
{
    public partial class FmFogetPassword : FormMain
    {
        // thread handle open new form
        private Thread threadForm;

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
            client.Credentials = new NetworkCredential("khanhvuongtuan37@gmail.com", "kh16111999");
            client.Send(mess);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Gmail = bunifuMetroTextbox3.Text;
            if(bunifuMetroTextbox2.Text == bunifuMetroTextbox1.Text)
                GuiMail("khanhvuongtuan37@gmail.com", Gmail, "Reset Password", "Mật khẩu mới của bạn là: " + bunifuMetroTextbox1.Text);
            this.Close();
        }
    }
}
