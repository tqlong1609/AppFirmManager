using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ManagerCinema
{
    public partial class UcLogin : UserControl
    {
        // thread handle open new form
        private Thread threadForm;
        public static TypeLogin typeLogin = TypeLogin.guest;

        public enum TypeLogin
        {
            user, manager, admin, guest
        }
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
            if (txtUsername.Text.Equals("user") && txtPassword.Text.Equals("1"))
            {
                typeLogin = TypeLogin.user;
            }
            if (txtUsername.Text.Equals("manager") && txtPassword.Text.Equals("1"))
            {
                typeLogin = TypeLogin.manager;
            }
            if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("1"))
            {
                typeLogin = TypeLogin.admin;
            }

            openFormFollowType(typeLogin);
        }

        private void openFormFollowType(TypeLogin typeLogin)
        {
            ((Form)this.TopLevelControl).Close();
            switch (typeLogin)
            {
                case TypeLogin.user:
                    // stay form1 present
                    break;
                case TypeLogin.manager:
                    // open form type manager

                    break;
                case TypeLogin.admin:
                    // open form type password

                    break;
            }
        }
    }
}
