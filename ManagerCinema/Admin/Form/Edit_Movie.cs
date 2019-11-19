using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;
using ManagerCinema.DBLayer;

namespace ManagerCinema
{

    public partial class Edit_Movie : Form
    {
        string idMovie;
        public Edit_Movie(string id)
        {
            InitializeComponent();
            idMovie = id;
        }

        private void Edit_Movie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string time = txtTime.Text;
            string director = textBox4.Text;
            string country = txtCountry.Text;
            string producer = txtProducer.Text;
            string type = txtType.Text;
            string Actor = txtActor.Text;
            string Date = txtDate.Text;
            string Content = txtContent.Text;
            string Price = txtPrice.Text;

            string sqlString = "Update Movie set Name = '" + name + "', Time = " + time + ", Director = " + director + ", Country = " + country + ", Producer = " + producer + ", Type = " + type + ", Actor = " + Actor + ", Date = " + Date + ", Content = " + Content + ", Price = " + Price + " where idMovie = " + idMovie;
            DBMain dBMain = new DBMain();
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
