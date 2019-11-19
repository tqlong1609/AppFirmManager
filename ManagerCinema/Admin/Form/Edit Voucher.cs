using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.DBLayer;

namespace ManagerCinema
{
    public partial class Edit_Voucher : Form
    {
        private string id;
        private DBMain dBMain;
        public Edit_Voucher(string idVoucher)
        {
            InitializeComponent();
            id = idVoucher;
        }

        private void Edit_Voucher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idUser = int.Parse(txtIdUser.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("idUser is not in the right format");
                return;
            }
            try
            {
                int Value = int.Parse(txtValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Value is not in the right format");
                return;
            }

            string status = checkBox1.Checked ? "1" : "0";

            string Name = txtName.Text;
            dBMain = new DBMain();
            string sqlString = "Update Voucher set idUser =" + txtIdUser.Text + ", Name = '" + Name + "', Value = " + txtValue.Text + ", Voucher.Voucher_Status = " + status + " where idVoucher = " + id;
            try
            {
                dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
                MessageBox.Show("Update completed");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Update Failed!");
                this.Close();
            }
        }

        private void Edit_Voucher_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
