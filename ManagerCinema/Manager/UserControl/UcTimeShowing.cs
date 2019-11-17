using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcTimeShowing : UserControl
    {
        private TimeBS TimeBS;
        public UcTimeShowing()
        {
            InitializeComponent();
        }

        private void UcTimeShowing_Load(object sender, System.EventArgs e)
        {
            TimeBS = new TimeBS();
            dgvData.DataSource = TimeBS.loadData();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            if (id == "")
            {
                dgvData.DataSource = TimeBS.loadData();
                return;
            }
            try
            {
                TimeBS = new TimeBS();
                var temp = TimeBS.Search_Time_Id(id);
                dgvData.DataSource = temp;
            }
            catch (Exception)
            {
                MessageBox.Show("Search string is not in the right format! Please type again");
            }
        }
    }
}
