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
        private string path = "";
        private EmployeeBS employeeBS;

        public FmAddEmployee()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkEmpty())
            {
                try
                {
                    bool status;
                    if(cbxStatus.Checked)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                    int salary = int.Parse(txtSalary.Text);
                    int identityCard = int.Parse(txtIdentityCard.Text);
                    employeeBS.insertEmployee(txtUsername.Text, txtPassword.Text, txtName.Text,
                        txtEmail.Text, dpkDateBirth.Value.ToLongDateString(), txtAddress.Text,
                        txtPhone.Text, salary, identityCard, dpkDateStartWork.Value.ToLongDateString(),
                        cbxPosition.selectedValue, status
                        , path);
                        MessageBox.Show("Add success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UcListEmployeeAD.isReset = true;
                        this.Close();
                }
                catch
                {
                    MessageBox.Show("Phone or salary or identityCard not type int", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Enter full value", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkEmpty()
        {
            if(txtUsername.Text == "" || txtPassword.Text=="" ||txtName.Text == "" || txtEmail.Text == ""
                || txtAddress.Text == "" || txtPhone.Text == "" || txtSalary.Text == "" || 
                txtIdentityCard.Text == "" || cbxPosition.selectedIndex == -1 || path == "")
            {
                return false;
            }
            return true;
        }

        private void FmAddEmployee_Load(object sender, EventArgs e)
        {
            employeeBS = new EmployeeBS();
        }
    }
}
