using ManagerCinema.ObjectFolder;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            button.Size = new Size(86, 23);
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
