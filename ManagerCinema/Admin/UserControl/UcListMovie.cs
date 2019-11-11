using System;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddMovie().ShowDialog();
        }
    }
}
