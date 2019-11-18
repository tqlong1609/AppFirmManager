using System;
using System.Data.SqlClient;
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if (id == "")
            {
                gvwVoucher.DataSource = VoucherBS.loadData();
                return;
            }
            VoucherBS = new VoucherBS();
            try
            {
                var temp = VoucherBS.Search_Voucher_Id(id);
                gvwVoucher.DataSource = temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = gvwVoucher.CurrentCell.RowIndex;
                string id =
                gvwVoucher.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Delete this record?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    VoucherBS.Delete_Voucher(id);
                    gvwVoucher.DataSource = VoucherBS.loadData();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Fail");
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            int r = gvwVoucher.CurrentCell.RowIndex;
            string id = gvwVoucher.Rows[r].Cells[0].Value.ToString();
            Edit_Voucher edit_Voucher = new Edit_Voucher(id);
            edit_Voucher.Show();
        }
    }
}
