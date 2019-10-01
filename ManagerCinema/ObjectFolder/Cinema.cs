using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    class Cinema
    {
        private string name;
        private List<Movie> arrMovies;
        private List<DateTime> timeShowing;
        private string nameCity;

        public Cinema(string name, List<Movie> arrMovies, List<DateTime> timeShowing, string nameCity)
        {
            this.name = name;
            this.arrMovies = arrMovies;
            this.timeShowing = timeShowing;
            this.nameCity = nameCity;
        }

        public string Name { get; set; }

        public List<Movie> ArrMovies { get; set; }

        public List<DateTime> TimeShowing { get; set; }

        public string NameCity { get; set; }

        
    }
}
