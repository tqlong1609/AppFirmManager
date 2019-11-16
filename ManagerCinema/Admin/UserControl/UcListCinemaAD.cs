using System;
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
    }
}
