using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class Movie
    {
        private Image image;
        private int time;
        private string nameMovie;
        private string director;
        private string producer;
        private string typeFirm;
        private string actor;
        private string date;
        private string content;
        private string country;
        private Status status;

        public enum Status
        {
            demonstration, vietsub, Engsub
        }

        public Movie(Image image, string nameMovie,int time, string director,
            string producer, string typeFirm, string actor, string date, 
            string content, string country, Status status)
        {
            this.director = director;
            this.producer = producer;
            this.typeFirm = typeFirm;
            this.actor = actor;
            this.date = date;
            this.content = content;
            this.country = country;
            this.status = status;
            this.time = time;
        }

        public Movie(Image image, string nameMovie)
        {
            this.image = image;
            this.nameMovie = nameMovie;
        }

        public Image getImage() {
            return image;
        }

        public string getNameMovie() {
            return nameMovie;
        }

        public string getDirector()
        {
            return director;
        }

        public string getProducer()
        {
            return producer;
        }

        public string getTypeFirm()
        {
            return typeFirm;
        }

        public string getActor()
        {
            return actor;
        }

        public string getDate()
        {
            return date;
        }

        public string getContent()
        {
            return content;
        }

        public string getCountry()
        {
            return country;
        }

        public Status getStatus()
        {
            return status;
        }

        public int getTime()
        {
            return time;
        }
    }
}
