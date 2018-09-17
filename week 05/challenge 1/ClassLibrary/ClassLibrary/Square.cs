using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Square : Quadrilateral
    {
        public Square(string _colour, int _Side1Length)
        {
            Side1Length = _Side1Length;
            Side2Length = _Side1Length;
            Side3Length = _Side1Length;
            Side4Length = _Side1Length;
            colour = _colour;
        }
        public int GetArea()
        {
            return (Side1Length * Side1Length);
        }

    }
}
