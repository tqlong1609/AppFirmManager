using ManagerCinema.BSLayer;
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
    public partial class FmAddCinema : FormMain
    {
        private CinemaBS cinemaBS;
        private string idCinema;
        private bool isEdit = false;    

        public FmAddCinema()
        {
            InitializeComponent();
        }

        public FmAddCinema(string idCinema)
        {
            InitializeComponent();
            this.idCinema = idCinema;
            isEdit = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmAddCinema_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAddCinema_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAddCinema_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkEmpty())
            {
                if (isEdit)
                {
                    if (cinemaBS.updateCinema(idCinema, txtName.Text, txtAddress.Text,
                        dpkTimeOpen.Value.ToShortTimeString(), dpkTimeClose.Value.ToShortTimeString()))
                    {
                        MessageBox.Show("Edit success", "Notificatin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcListCinemaAD.isReset = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Edit fail", "Notificatin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (cinemaBS.insertCinema(CommonFunction.getIdOnTime(), txtName.Text, txtAddress.Text,
                        dpkTimeOpen.Value.ToShortTimeString(), dpkTimeClose.Value.ToShortTimeString()))
                    {
                        MessageBox.Show("Add success", "Notificatin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcListCinemaAD.isReset = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Add fail", "Notificatin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool checkEmpty()
        {
            if(txtAddress.Text == "" || txtName.Text == "")
            {
                return false;
            }
            return true;
        }

        private void FmAddCinema_Load(object sender, EventArgs e)
        {
            cinemaBS = new CinemaBS();
        }
    }
}
