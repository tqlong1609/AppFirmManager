using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class User
    {
        private int countTicketNomal;
        private int countTicketBench;
        private string nameMovie;
        private int sumMoney;
        private List<string> seats;
        // ...

        public int CountTicketNomal { get; set; }
        public int CountTicketBench { get; set; }
        public int SumMoney { get; set; }
        

    }
}
