using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListBackground : UserControl
    {
        private int indexRow;
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
            if (id == "")
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dgvData.Rows.Count > 0 && indexRow >= 0)
            {
                string id = dgvData.Rows[indexRow].Cells[0].Value.ToString();
                if(TicketBS.paymentTicket(id))
                {
                    MessageBox.Show("Payment success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvData.DataSource = TicketBS.loadData();
                }
                else
                {
                    MessageBox.Show("Payment fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }
    }
}
