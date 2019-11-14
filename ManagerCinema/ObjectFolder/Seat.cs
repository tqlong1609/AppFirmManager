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
        protected bool status;

        public void setStatus(bool status)
        {
            this.status = status;
        }

        public bool getStatus()
        {
            return status;
        }

        public Seat(string name,bool status)
        {
            this.name = name;
            this.status = status;
        }

        public string getName()
        {
            return name;
        }
    }
}
