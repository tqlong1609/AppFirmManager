using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListEmployeeAD : UserControl
    {
        private EmployeeBS EmployeeBS;
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
    }
}
