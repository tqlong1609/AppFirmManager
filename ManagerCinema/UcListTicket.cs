using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListTicket : UserControl
    {
        private TicketBS TicketBS;
        public UcListTicket()
        {
            InitializeComponent();
        }

        private void UcListTicket_Load(object sender, EventArgs e)
        {
            TicketBS = new TicketBS();
            dataGridView1.DataSource = TicketBS.loadData();
        }
    }
}
