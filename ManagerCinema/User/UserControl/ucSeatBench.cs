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
    public partial class ucSeatBench : UserControl
    {
        private SeatBench seatBench;

        public ucSeatBench(SeatBench seatBench)
        {
            InitializeComponent();
            this.seatBench = seatBench;
            lbRow.Text = seatBench.getName();
        }

        public Button createButton(string text)
        {
            Button button = new Button();
            button.Text = text;
            button.Size = new Size(86,23);
            button.BackColor = Color.Gray;
            button.FlatStyle = FlatStyle.Flat;
            return button;
        }

        private void ucSeatBench_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < seatBench.getArrSeat().Count(); i++)
            {
                pnlSeat.Controls.Add(createButton(seatBench.getArrSeat()[i].getName()));
            }
        }
    }
}
