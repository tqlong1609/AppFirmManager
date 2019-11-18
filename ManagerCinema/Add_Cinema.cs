using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class Add_Cinema : Form
    {
        public Add_Cinema()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

            if(CinemaBS.isExisted(id) == "True")
            {
                MessageBox.Show("This cinema is already existed");
                return;
            }
            try
            {
                CinemaBS.Add_Cinema(id, name, address, count, open, close);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
