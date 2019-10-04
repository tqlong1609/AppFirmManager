using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class UcPermistionLogin : UserControl
    {
        private Panel panel;

        public UcPermistionLogin(Panel pnlChangePermisstion)
        {
            InitializeComponent();
            this.panel = pnlChangePermisstion;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FmLogin(panel).ShowDialog();
        }
    }
}
