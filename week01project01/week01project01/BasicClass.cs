using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace week01project01
{
    class Game
    {

        public string Name;

        public int Rating;

        private List<int> Ratings;

        public double Price;

        public string Description;

        public string Genre;

        public Game(string name, double price, string desc, string genre)
        {
            this.Name = name;
            this.Price = price;
            this.Description = desc;
            this.Genre = genre;
            this.Ratings = new List<int>();
        }
        public void ReviewGame(int rating)
        {
            Ratings.Add(rating);
            Rating = Convert.ToInt32(Ratings.Average());

        }
    }
}
