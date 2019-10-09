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
    public partial class FmHomeManager : FormMain
    {
        private Thread threadForm;

        public FmHomeManager()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmHomeManager_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e,this);
        }

        private void FmHomeManager_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmHomeManager_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure logout ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                threadForm = new Thread(openFormLogin);
                threadForm.SetApartmentState(ApartmentState.STA);
                threadForm.Start();
            }
        }

        private void openFormLogin()
        {
            Application.Run(new FmLogin());
        }
    }
}
