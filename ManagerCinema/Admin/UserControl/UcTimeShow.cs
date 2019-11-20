using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcTimeShow : UserControl
    {
        public static bool isReset = false;
        private TimeBS timeBS;
        private int index;
        private DataTable dataTime;

        public UcTimeShow()
        {
            InitializeComponent();
        }

        private void UcTimeShow_Load(object sender, EventArgs e)
        {
            timeBS = new TimeBS();
            loadData();
        }

        public void loadData()
        {
            dataTime = timeBS.getAllTimeShowing();
            gvwTime.DataSource = dataTime;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddTimeShowing().ShowDialog();
            if (isReset)
            {
                loadData();
                isReset = false;
            }
        }

        private void gvwTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(index >= 0 && gvwTime.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes) {
                    if (timeBS.removeTimeShowing(gvwTime.Rows[index].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Remove Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        index = 0;
                    }
                    else
                    {
                        MessageBox.Show("Remove fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index >= 0 && gvwTime.Rows.Count > 0)
            {
                new FmAddTimeShowing(gvwTime.Rows[index].Cells[0].Value.ToString()).ShowDialog();
                if (isReset)
                {
                    loadData();
                    isReset = false;
                }
            }
        }

    }
}
