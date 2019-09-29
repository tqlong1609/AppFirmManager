using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCinema.ObjectFolder;
using System.Runtime.InteropServices;
using System;

namespace ManagerCinema
{
    public partial class UcDetailMovie : UserControl
    {

        public UcDetailMovie()
        {
            InitializeComponent();
        }

        private void UcDetailMovie_Load(object sender, System.EventArgs e)
        {
            Label label = getLabel("12:30");
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
            flpTime.Controls.Add(label);
        }

        private Label getLabel(string time)
        {
            Label label = new Label();
            label.ForeColor = Color.White;
            label.Text = time;
            label.Font = new Font(new FontFamily("Arial"), (float)9.75);
            label.Size = new Size(45, 16);
            label.BorderStyle = BorderStyle.Fixed3D;
            return label;
        }
    }
}
