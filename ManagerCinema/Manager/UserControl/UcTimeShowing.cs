﻿using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcTimeShowing : UserControl
    {
        private TimeBS TimeBS;
        public UcTimeShowing()
        {
            InitializeComponent();
        }

        private void UcTimeShowing_Load(object sender, System.EventArgs e)
        {
            TimeBS = new TimeBS();
            dgvData.DataSource = TimeBS.loadData();
        }
    }
}
