using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcTimeShow : UserControl
    {
        private TimeBS TimeBS;
        public UcTimeShow()
        {
            InitializeComponent();
        }

        private void UcTimeShow_Load(object sender, EventArgs e)
        {
            TimeBS = new TimeBS();
            dwvTime.DataSource = TimeBS.loadData();
        }
    }
}
