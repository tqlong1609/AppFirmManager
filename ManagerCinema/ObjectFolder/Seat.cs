using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class Seat
    {
        protected string name;

        public Seat(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
