using System;
using System.Windows.Forms;
using BarcodeLibTest;
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
            gvwVoucher.DataSource = VoucherBS.loadData();
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            TestApp new_Voucher = new TestApp();
            new_Voucher.ShowDialog();
        }
    }
}
