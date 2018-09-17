using System;
using System.Collections.Generic;
using System.Text;

namespace week01project01
{
    class Cookie
    {
        public string Shape;

        public string Colour;

        public string Topping;

        public DateTime DateCreated;

        public int UseBy = 4;

        public Cookie(string shape, string colour, string topping, DateTime datecreated)
        {
            this.Shape = shape;
            this.Colour = colour;
            this.Topping = topping;
            this.DateCreated = datecreated;
        }

        public void changeTopping(string newTopping)
        {
            this.Topping = newTopping;
        }

        public bool isExpired()
        {
            TimeSpan difference = DateTime.Now - DateCreated;
            if (difference.Days > UseBy)
            { return true; }
            else
            { return false; }
        }

        public override string ToString()
        {
            return "A " + this.Shape + ", " + this.Colour + " cookie with " + this.Topping + " on it. made on " + this.DateCreated;
        }
    }
}
