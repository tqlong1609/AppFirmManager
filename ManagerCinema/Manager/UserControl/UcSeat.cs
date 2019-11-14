﻿using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcSeat : UserControl
    {
        private SeatBS SeatBS;
        public UcSeat()
        {
            InitializeComponent();
        }

        private void UcSeat_Load(object sender, System.EventArgs e)
        {
            SeatBS = new SeatBS();
            dgvData.DataSource = SeatBS.loadData();
        }
    }
}
