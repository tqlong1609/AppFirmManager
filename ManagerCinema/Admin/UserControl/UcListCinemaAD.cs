using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListCinemaAD : UserControl
    {
        private CinemaBS CinemaBS;
        public UcListCinemaAD()
        {
            InitializeComponent();
        }

        private void UcListCinemaAD_Load(object sender, System.EventArgs e)
        {
            CinemaBS = new CinemaBS();
            gvwCinema.DataSource = CinemaBS.loadData();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Add_Cinema add_Movie = new Add_Cinema();
            add_Movie.Show();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int r = gvwCinema.CurrentCell.RowIndex;
                string id =
                gvwCinema.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Delete this record?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    CinemaBS.Delete_Cinema(id);
                    gvwCinema.DataSource = CinemaBS.loadData();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Fail");
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            int r = gvwCinema.CurrentCell.RowIndex;
            string id = gvwCinema.Rows[r].Cells[0].Value.ToString();
            Edit_Cinema edit_Cinema = new Edit_Cinema();
            edit_Cinema.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if (id == "")
            {
                gvwCinema.DataSource = CinemaBS.loadData();
                return;
            }
            CinemaBS = new CinemaBS();
            try
            {
                var temp = CinemaBS.Search_Voucher_Id(id);
                gvwCinema.DataSource = temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }
    }
}
