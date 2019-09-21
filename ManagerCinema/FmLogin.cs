using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmLogin : FormMain
    {
        private Size sizeFormDefault;
        private bool isFormLogin;

        public FmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region move form
        private void FmLogin_MouseDown(object sender, MouseEventArgs e) {
            mouseDownForm(e,this);
        }

        private void FmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        private void lbLogin_Click(object sender, EventArgs e)
        {
            if (!isFormLogin)
            {
                lbLoginT.Visible = true;
                lbRegisterT.Visible = false;
                pnlBackground.Controls.Clear();
                addUseControlLogin();
                isFormLogin = true;
            }
        }

        private void addUseControlLogin()
        {
            UcLogin ucLogin = new UcLogin();
            pnlBackground.Size = ucLogin.Size;
            this.Size = sizeFormDefault;
            pnlBackground.Controls.Add(ucLogin);
        }


        private void lbRegister_Click(object sender, EventArgs e)
        {
            if (isFormLogin)
            {
                lbLoginT.Visible = false;
                lbRegisterT.Visible = true;
                pnlBackground.Controls.Clear();
                addUseControlRegister();
                isFormLogin = false;
            }
        }

        private void addUseControlRegister()
        {
            UcRegister ucLogin = new UcRegister();
            this.Height = (ucLogin.Height - pnlBackground.Height) + sizeFormDefault.Height;
            pnlBackground.Size = ucLogin.Size;
            pnlBackground.Controls.Add(ucLogin);
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            lbRegisterT.Visible = false;
            sizeFormDefault = this.Size;
            addUseControlLogin();
            isFormLogin = true;
        }

        private void lbFogetPass_Click(object sender, EventArgs e)
        {
        }
    }
}
