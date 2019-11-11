using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcLogin : UserControl
    {
        // thread handle open new form
        private Thread threadForm;
        private LoginBS LoginBS;
        public UcLogin()
        {
            InitializeComponent();
        }

        private void lbFogetPass_Click(object sender, EventArgs e)
        {
            // open new form
            ((Form)this.TopLevelControl).Close();
            threadForm = new Thread(openFormForgetPassword);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormForgetPassword()
        {
            Application.Run(new FmFogetPassword());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("manager") && txtPassword.Text.Equals("1"))
            {
                TypeLogin.typeLogin = ETypeLogin.manager;
            }
            else if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("1"))
            {
                TypeLogin.typeLogin = ETypeLogin.admin;
            }
            else
            {
                string Username = txtUsername.Text;
                string Password = txtPassword.Text;
                LoginBS = new LoginBS();
                string Result = LoginBS.Login(Username, Password);
                if (Result == "1")
                    TypeLogin.typeLogin = ETypeLogin.user;
                else
                {
                    MessageBox.Show("Enter your username or password incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            openFormFollowType(TypeLogin.typeLogin);
        }

        private void openFormFollowType(ETypeLogin typeLogin)
        {
            ((Form)this.TopLevelControl).Close();
            switch (typeLogin)
            {
                case ETypeLogin.user:
                    threadForm = new Thread(openFormUser);
                    threadForm.SetApartmentState(ApartmentState.STA);
                    threadForm.Start();
                    break;
                case ETypeLogin.manager:
                    threadForm = new Thread(openFormManager);
                    threadForm.SetApartmentState(ApartmentState.STA);
                    threadForm.Start();
                    break;
                case ETypeLogin.admin:
                    threadForm = new Thread(openformAdmin);
                    threadForm.SetApartmentState(ApartmentState.STA);
                    threadForm.Start();
                    break;
            }
        }

        private void openFormManager()
        {
            Application.Run(new FmHomeManager());

        }

        private void openFormUser()
        {
            Application.Run(new Form1());
        }

        private void openformAdmin()
        {
            Application.Run(new FmAdmin());
        }
    }
}
