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
    public partial class FmAddEmployee : FormMain
    {
        private EmployeeBS employeeBS;
        private string path;

        public FmAddEmployee()
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

        private void FmAddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAddEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAddEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(fileDialog.FileName);
                path = fileDialog.FileName;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = CommonFunction.getIdOnTime();
            if(employeeBS.insertEmployee(id, txtName.Text, txtEmail.Text, dpkDateBorn.Value.ToLongDateString(), txtAddress.Text,
                txtPhone.Text, int.Parse(txtSalary.Text), int.Parse(txtIdentityCard.Text), dpkDateStart.Value.ToLongDateString(),
                ddwPosition.selectedValue, true, path))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FmAddEmployee_Load(object sender, EventArgs e)
        {
            employeeBS = new EmployeeBS();
        }
    }
}
