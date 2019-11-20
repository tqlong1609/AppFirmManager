using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;
using ManagerCinema.DBLayer;
using ManagerCinema.ObjectFolder;

namespace ManagerCinema
{
    public partial class Edit_Voucher : FormMain
    {
        private string id;
        private string name, value, status;

        private VoucherBS voucherBS;

        public Edit_Voucher(string idVoucher,string name, string value, string status)
        {
            InitializeComponent();
            id = idVoucher;
            this.name = name;
            this.value = value;
            this.status = status.ToLower();
        }

        private void Edit_Voucher_Load(object sender, EventArgs e)
        {
            voucherBS = new VoucherBS();

            txtName.Text = name;
            txtValue.Text = value;
            cbxValue.Checked = status == "true" ? true : false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Edit_Voucher_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void Edit_Voucher_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void Edit_Voucher_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtValue.Text != "")
            {
                try
                {
                    int Value = int.Parse(txtValue.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Value have to int value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string status = cbxValue.Checked ? "1" : "0";

                string Name = txtName.Text;
                if (voucherBS.EditVoucher(id, txtName.Text, value, status))
                {
                    MessageBox.Show("Edit success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcListVoucher.isReset = true;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Edit fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            {
                MessageBox.Show("You have to enter full value", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
