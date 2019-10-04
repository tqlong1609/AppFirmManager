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
using ManagerCinema.ObjectFolder;

namespace ManagerCinema
{
    public partial class UcLogin : UserControl
    {
        // thread handle open new form
        private Panel panel;
        private Thread threadForm;
        public static ETypeLogin typeLogin = ETypeLogin.guest;

        public UcLogin(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
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
            Application.Run(new FmFogetPassword(panel));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("user") && txtPassword.Text.Equals("1"))
            {
                typeLogin = ETypeLogin.user;
            }
            else if (txtUsername.Text.Equals("manager") && txtPassword.Text.Equals("1"))
            {
                typeLogin = ETypeLogin.manager;
            }
            else if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("1"))
            {
                typeLogin = ETypeLogin.admin;
            }
            else
            {
                MessageBox.Show("Enter your username or password incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            openFormFollowType(typeLogin);
        }

        private void openFormFollowType(ETypeLogin typeLogin)
        {
            ((Form)this.TopLevelControl).Close();
            switch (typeLogin)
            {
                case ETypeLogin.user:
                    panel.Controls.Clear();
                    panel.Controls.Add(new UcPermistionUser());
                    break;
                case ETypeLogin.manager:

                    break;
                case ETypeLogin.admin:
                    // open form type password

                    break;
            }
        }
    }
}
