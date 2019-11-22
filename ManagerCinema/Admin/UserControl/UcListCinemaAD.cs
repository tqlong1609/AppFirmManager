using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListCinemaAD : UserControl
    {
        private int indexRow;
        public static bool isReset = false; 
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

        // add
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new FmAddCinema().ShowDialog();
            if(isReset)
            {
                gvwCinema.DataSource = CinemaBS.loadData();
                isReset = false;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            int r = gvwCinema.CurrentCell.RowIndex;
            string id = gvwCinema.Rows[r].Cells[0].Value.ToString();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FmAddCinema(gvwCinema.Rows[indexRow].Cells[0].Value.ToString()).ShowDialog();
            if (isReset)
            {
                gvwCinema.DataSource = CinemaBS.loadData();
                isReset = false;
            }
        }

        private void gvwCinema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }
    }
}
