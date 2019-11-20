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
        public static bool isReset = false;

        public UcListVoucher()
        {
            InitializeComponent();
        }

        private void UcListVoucher_Load(object sender, EventArgs e)
        {
            VoucherBS = new VoucherBS();
            loadData();
        }

        private void loadData()
        {
            gvwVoucher.DataSource = VoucherBS.loadData();
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            TestApp new_Voucher = new TestApp();
            new_Voucher.ShowDialog();
            if (TestApp.isReset)
            {
                loadData();
                TestApp.isReset = false;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvwVoucher.Rows.Count > 0)
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Fail");
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (gvwVoucher.Rows.Count > 0)
            {
                int r = gvwVoucher.CurrentCell.RowIndex;
                string id = gvwVoucher.Rows[r].Cells[0].Value.ToString();
                string name = gvwVoucher.Rows[r].Cells[1].Value.ToString();
                string value = gvwVoucher.Rows[r].Cells[2].Value.ToString();
                string status = gvwVoucher.Rows[r].Cells[3].Value.ToString();
                Edit_Voucher edit_Voucher = new Edit_Voucher(id,name,value,status);
                edit_Voucher.ShowDialog();
                if(isReset)
                {
                    loadData();
                    isReset = false;
                }
            }
        }
    }
}
