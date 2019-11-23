using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListEmployeeAD : UserControl
    {
        private EmployeeBS EmployeeBS;
        private int index;
        public static bool isReset = false;

        public UcListEmployeeAD()
        {
            InitializeComponent();
        }

        private void UcListEmployeeAD_Load(object sender, EventArgs e)
        {
            EmployeeBS = new EmployeeBS();
            loadData();
        }

        private void loadData()
        {
            gvwEmployee.DataSource = EmployeeBS.loadData();
            gvwEmployee.Columns["Image"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddEmployee().ShowDialog();
            if(isReset)
            {
                loadData();
                isReset = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = gvwEmployee.Rows[index].Cells[0].Value.ToString();
            if(EmployeeBS.removeEmployee(id))
            {
                MessageBox.Show("remove success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("remove fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
