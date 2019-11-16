using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListSeat : UserControl
    {
        private SeatBS SeatBS;
        public UcListSeat()
        {
            InitializeComponent();
        }

        private void UcListSeat_Load(object sender, EventArgs e)
        {
            SeatBS = new SeatBS();
            gvwSeat.DataSource = SeatBS.loadData();
        }
    }
}
