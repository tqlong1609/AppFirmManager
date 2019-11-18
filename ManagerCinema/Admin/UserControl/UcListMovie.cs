using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListMovie : UserControl
    {
        private MovieBS movieBS;

        public UcListMovie()
        {
            InitializeComponent();
        }

        private void UcListMovie_Load(object sender, EventArgs e)
        {
            movieBS = new MovieBS();
            dvwMovies.DataSource = movieBS.loadData();
            dvwMovies.Columns["Image"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddMovie().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if (id == "")
            {
                dvwMovies.DataSource = movieBS.loadData();
                return;
            }
            movieBS = new MovieBS();
            try
            {
                var temp = movieBS.Search_Movie_Id(id);
                dvwMovies.DataSource = temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dvwMovies.CurrentCell.RowIndex;
                string id =
                dvwMovies.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Delete this record?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    movieBS.Delete_Movie(id);
                    dvwMovies.DataSource = movieBS.loadData();
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
            int r = dvwMovies.CurrentCell.RowIndex;
            string id = dvwMovies.Rows[r].Cells[0].Value.ToString();
            Edit_Movie edit_Movie = new Edit_Movie(id);
            edit_Movie.Show();
        }
    }
}
