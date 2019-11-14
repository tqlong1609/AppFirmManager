using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListBackground : UserControl
    {
        private TicketBS TicketBS;
        public UcListBackground()
        {
            InitializeComponent();
        }

        private void UcListBackground_Load(object sender, EventArgs e)
        {
            TicketBS = new TicketBS();
            dgvData.DataSource = TicketBS.loadData();
        }


        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
