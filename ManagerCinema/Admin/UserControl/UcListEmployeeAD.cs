using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListEmployeeAD : UserControl
    {
        private EmployeeBS EmployeeBS;
        private int index;
        public UcListEmployeeAD()
        {
            InitializeComponent();
        }

        private void UcListEmployeeAD_Load(object sender, EventArgs e)
        {
            EmployeeBS = new EmployeeBS();
            gvwEmployee.DataSource = EmployeeBS.loadData();
            gvwEmployee.Columns["Image"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FmAddEmployee().ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = gvwEmployee.Rows[index].Cells[0].Value.ToString();
        }

        private void gvwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
