using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCinema.ObjectFolder;

namespace ManagerCinema
{
    public partial class UcPermistionUser : UserControl
    {
        private Panel panel;

        public UcPermistionUser(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure log out ?","Question",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panel.Controls.Clear();
                panel.Controls.Add(new UcPermistionLogin(panel));
                TypeLogin.typeLogin = ETypeLogin.guest;
            }
        }

        private void pbxProfile_Click(object sender, EventArgs e)
        {
            new FmProfile().ShowDialog();
        }
    }
}
