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
            button.Size = new Size(45,23);
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
