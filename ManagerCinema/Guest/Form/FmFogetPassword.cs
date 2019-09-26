using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
