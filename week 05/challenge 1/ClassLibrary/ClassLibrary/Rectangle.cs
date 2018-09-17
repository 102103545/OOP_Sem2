using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string _colour,int _Side1Length, int _Side2Length)
        {
            Side1Length = _Side1Length;
            Side2Length = _Side2Length;
            Side3Length = _Side1Length;
            Side4Length = _Side2Length;
            colour = _colour;
        }
        public int GetArea()
        {
            return (Side1Length * Side2Length);
        }

    }
}
