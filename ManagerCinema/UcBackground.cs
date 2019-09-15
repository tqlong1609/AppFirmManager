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
    public partial class UcBackground : UserControl
    {
        public UcBackground()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.Blue;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.Yellow;
        }
    }
}
