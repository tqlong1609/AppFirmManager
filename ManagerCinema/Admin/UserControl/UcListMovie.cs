using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListMovie : UserControl
    {
        private MovieBS movieBS;
        public static bool isReset = false;
        private int indexRow;

        public UcListMovie()
        {
            InitializeComponent();
        }

        private void UcListMovie_Load(object sender, EventArgs e)
        {
            movieBS = new MovieBS();

            loadData();
            
        }

        private void loadData()
        {
            dvwMovies.DataSource = movieBS.loadData();
            dvwMovies.Columns["Image"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddMovie().ShowDialog();
            if(isReset)
            {
                dvwMovies.DataSource = movieBS.loadData();
                isReset = false;
            }
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

        private void dvwMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dvwMovies.Rows.Count > 0 && indexRow >=0 )
            {
                new FmAddMovie(dvwMovies.Rows[indexRow].Cells[0].Value.ToString()).ShowDialog();
                if(isReset)
                {
                    loadData();
                    isReset = false;
                }
            }
        }
    }
}
