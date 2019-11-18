using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;
using ManagerCinema.DBLayer;

namespace ManagerCinema
{
    public partial class Edit_Cinema : Form
    {
        public Edit_Cinema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int test = int.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("ID format is not accepted");
                return;
            }

            string id = txtID.Text;
            string name = txtName.Text;
            string address = txtAddress.Text;
            string count = txtNumber.Text;
            string open = txtOpen.Text;
            string close = txtClose.Text;
            CinemaBS CinemaBS = new CinemaBS();
            if (CinemaBS.isExisted(id) == "False")
            {
                MessageBox.Show("Invalid Cinema");
                return;
            }
            DBMain dBMain = new DBMain();
            string sqlString = "Update Cinema set idCinema =" + id + ", Name = '" + name + "', Address = " + address + ", CountRoom = " + count + ", TimeOpen = " + open + ", TimeClose = " + close + " where idCinema = " + id;
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
    }
}
