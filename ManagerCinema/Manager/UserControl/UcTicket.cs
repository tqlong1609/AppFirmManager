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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if(id == "")
            {
                dgvData.DataSource = TicketBS.loadData();
                return;
            }
            try
            {
                TicketBS = new TicketBS();
                var temp = TicketBS.Search_Ticket_Id(id);
                dgvData.DataSource = temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }
    }
}
