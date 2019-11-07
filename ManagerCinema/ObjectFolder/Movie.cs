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
        private int id;
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
        private int price;


        public Movie(int id,Image image, string nameMovie,int time, string director,
            string producer, string typeFirm, string actor, string date, 
            string content, string country, int price)
        {
            this.id = id;
            this.nameMovie = nameMovie;
            this.image = image;
            this.director = director;
            this.producer = producer;
            this.typeFirm = typeFirm;
            this.actor = actor;
            this.date = date;
            this.content = content;
            this.country = country;
            this.price = price;
            this.time = time;
        }

        public int getId()
        {
            return id;
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

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getCountry()
        {
            return country;
        }

        public int getPrice()
        {
            return price;
        }

        public int getTime()
        {
            return time;
        }
    }
}
