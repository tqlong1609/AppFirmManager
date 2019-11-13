using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class Ticket
    {
        private int idUser;
        private int idCinema;
        private int idRoomCinema;
        private string time;
        private string date;
        private int idMovie;
        private string nameSeat;
        private int price;

        public int IdUser
        {
            get { return idUser; }
            set { this.idUser = value; }
        }

        public int IdRoomCinema
        {
            get { return idRoomCinema; }
            set { this.idRoomCinema = value; }
        }

        public string Time
        {
            get { return time; }
            set { this.time = value; }
        }

        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public string NameSeat
        {
            get { return nameSeat; }
            set { this.nameSeat = value; }
        }

        public int IdCinema
        {
            get { return idCinema; }
            set { this.idCinema = value; }
        }

        public int IdMovie
        {
            get { return idMovie; }
            set { this.idMovie = value; }
        }

        public int Price
        {
            get { return price; }
            set { this.price = value; }
        }
    }
}
