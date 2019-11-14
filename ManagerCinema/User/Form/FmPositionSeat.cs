﻿using ManagerCinema.BSLayer;
using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmPositionSeat : FormMain
    {
        private MovieBS movieBS;
        private List<SeatNomal> arrRowSeatNomal;
        private List<SeatBench> arrRowSeatBench;
        private List<string> listRows;
        private List<string> listColumns;
        private DataTable tableSeats;
        private Thread threadForm;
        private Movie movie;
        private User user;
        private int countNomal;
        private int countBench;
        private int idCinema;
        private int idRoomCinema;
        private string nameSeat;

        public FmPositionSeat(Movie movie, User user, int idCinema)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
            this.idCinema = idCinema;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Form Move
        private void FmPositionSeat_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmPositionSeat_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmPositionSeat_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        private void FmPositionSeat_Load(object sender, EventArgs e)
        {
            listRows = new List<string>();
            listColumns = new List<string>();
            movieBS = new MovieBS();

            loadValueInforSeat();

            countNomal = user.CountTicketNomal;
            countBench = user.CountTicketBench;
            lbCountNomal.Text = countNomal.ToString();
            lbCountBench.Text = countBench.ToString();

        }

        private void loadValueInforSeat()
        {
            List<string> listSeat = new List<string>(); 
            tableSeats = movieBS.getInforSeatFromIdCinema(idCinema);

            foreach(DataRow rows in tableSeats.Rows)
            {
                listSeat.Add(rows["NameRoom"].ToString());
            }

            listSeat = listSeat.Distinct().ToList();

            foreach(string value in listSeat)
            {
                cbxRoomCinema.AddItem(value);
            }
        }

        private void loadListSeatNomal(string nameRoom)
        {
            List<Seat> seatsNomal = new List<Seat>();
            arrRowSeatNomal = new List<SeatNomal>();

            cbxRows.Clear();
            listRows.Clear();

            char tempRow = 'A';
            foreach (DataRow rows in tableSeats.Rows)
            {
                if (nameRoom.Equals(rows["NameRoom"].ToString().Trim()))
                {
                    idRoomCinema = int.Parse(rows["idRoomCinema"].ToString().Trim());
                    // A1 => nameRow: A , nameColumn: 1
                    char nameRow = rows["NameSeat"].ToString()[0];
                    if (tempRow == nameRow)
                    {
                        char nameColumn = rows["NameSeat"].ToString()[1];
                        seatsNomal.Add(new Seat(nameColumn.ToString(),getStatus(rows["StatusSeat"].ToString())));
                    }
                    else
                    {
                        listRows.Add(tempRow.ToString());
                        pnlSeat.Controls.Add(new ucSeatNomal(new SeatNomal(tempRow.ToString(), seatsNomal)));
                        seatsNomal.Clear();
                        seatsNomal.Add(new Seat(rows["NameSeat"].ToString()[1].ToString(), getStatus(rows["StatusSeat"].ToString())));
                        tempRow = nameRow;
                    }
                }
            }
            listRows.Add(tempRow.ToString());
            addListRows();
            pnlSeat.Controls.Add(new ucSeatNomal(new SeatNomal(tempRow.ToString(), seatsNomal)));
        }

        private bool getStatus(string status)
        {
            if (status == "True")
                return true;
            return false;
        }

        private void addListRows()
        {
            foreach(string temp in listRows)
            {
                cbxRows.AddItem(temp);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormTicket);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormTicket()
        {
            Application.Run(new FmTicket(movie));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            setTicket();
            this.Close();
            threadForm = new Thread(openFormReview);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void setTicket()
        {
            nameSeat = cbxRows.selectedValue + cbxColumns.selectedValue;
            UcLogin.ticket.IdRoomCinema = idRoomCinema;
            UcLogin.ticket.NameSeat = nameSeat;
            UcLogin.ticket.NameRoom = cbxRoomCinema.selectedValue;
        }

        private void openFormReview()
        {
            Application.Run(new FmReview(movie, user, idCinema));
        }

        private void cbxRoomCinema_onItemSelected(object sender, EventArgs e)
        {
            pnlSeat.Controls.Clear();
            loadListSeatNomal(cbxRoomCinema.selectedValue);
        }

        private void cbxRows_onItemSelected(object sender, EventArgs e)
        {
            cbxColumns.Clear();
            char valueRow = cbxRows.selectedValue.ToCharArray()[0];
            foreach (DataRow row in tableSeats.Rows)
            {
                if (row["NameSeat"].ToString().ToCharArray()[0].Equals(valueRow)
                    && row["NameRoom"].ToString().Equals(cbxRoomCinema.selectedValue))
                {
                    if (row["StatusSeat"].ToString() == "True")
                    {
                        cbxColumns.AddItem(row["NameSeat"].ToString()[1].ToString());
                    }
                }
            }
        }
    }
}
