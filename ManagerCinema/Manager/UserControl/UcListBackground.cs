using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ManagerCinema.ObjectFolder.ETypeLoadData;

namespace ManagerCinema
{
    public partial class UcListBackground : UserControl
    {
        private TypeLoad typeLoad;

        public UcListBackground(TypeLoad typeLoad)
        {
            InitializeComponent();
            this.typeLoad = typeLoad;
        }

        private void UcListBackground_Load(object sender, EventArgs e)
        {
            switch(typeLoad)
            {
                case TypeLoad.ListTicket:
                    loadDataListTicket();
                    break;
                case TypeLoad.ListSeat:
                    loadDataListSeat();
                    break;
                case TypeLoad.ListTimeShowing:
                    loadDataListTimeShowing();
                    break;
            }
        }

        private void loadDataListTimeShowing()
        {
            txtSearch.Text = "Search timeshowing...";
        }

        private void loadDataListSeat()
        {
            txtSearch.Text = "Search seat...";
        }

        private void loadDataListTicket()
        {
            txtSearch.Text = "Search ticket...";
        }
    }
}
