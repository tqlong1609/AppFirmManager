using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class UcListBackground : UserControl
    {
        private FmHomeManager form;
        public UcListBackground(FmHomeManager form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void UcListBackground_Load(object sender, EventArgs e)
        {
            loadDataListTicket();
        }

        private void loadDataListTicket()
        {
            FmLogin.connectServer.loadDataFromServer(dgvData, this, CodeData.TICKET_LOAD_ALL, btnReload);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    }
}
