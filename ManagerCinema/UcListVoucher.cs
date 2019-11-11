using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListVoucher : UserControl
    {
        private VoucherBS VoucherBS;
        public UcListVoucher()
        {
            InitializeComponent();
        }

        private void UcListVoucher_Load(object sender, EventArgs e)
        {
            VoucherBS = new VoucherBS();
            dataGridView1.DataSource = VoucherBS.loadData();
        }
    }
}
