using ManagerCinema.ObjectFolder;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class ucSeatNomal : UserControl
    {
        private SeatNomal seatNomal;

        public ucSeatNomal(SeatNomal seatNomal)
        {
            InitializeComponent();
            this.seatNomal = seatNomal;
            lbRow.Text = seatNomal.getName();
        }

        private Button createButton(string text)
        {
            Button button = new Button();
            button.Size = new Size(45, 23);
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Gray;
            button.Text = text;
            return button;
        }

        private void ucSeatNomal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < seatNomal.getArrSeat().Count(); i++)
            {
                pnlSeat.Controls.Add(createButton(seatNomal.getArrSeat()[i].getName()));
            }
        }
    }
}
