using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class SeatBench
    {
        private string name;
        private List<Seat> arrSeats;

        public SeatBench(string name, List<Seat> arrSeats)
        {
            this.name = name;
            this.arrSeats = arrSeats;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setArrSeats(List<Seat> seats)
        {
            this.arrSeats = seats;
        }

        public List<Seat> getArrSeat()
        {
            return arrSeats;
        }
    }
}
