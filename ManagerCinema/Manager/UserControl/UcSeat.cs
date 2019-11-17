using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcSeat : UserControl
    {
        private SeatBS SeatBS;
        public UcSeat()
        {
            InitializeComponent();
        }

        private void UcSeat_Load(object sender, System.EventArgs e)
        {
            SeatBS = new SeatBS();
            dgvData.DataSource = SeatBS.loadData();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if (id == "")
            {
                dgvData.DataSource = SeatBS.loadData();
                return;
            }
            SeatBS = new SeatBS();
            try
            {
                var temp = SeatBS.Search_Seat_Id(id);
                dgvData.DataSource = temp;
            }
            catch(Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }
    }
}
