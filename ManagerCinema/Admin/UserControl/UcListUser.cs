using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListUser : UserControl
    {
        private UserBS UserBS;
        public UcListUser()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            UserBS = new UserBS();
            dataGridView1.DataSource = UserBS.loadData();
        }
    }
}
