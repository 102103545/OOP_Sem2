using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EquilateralTriangle:Triangle
    {
        public EquilateralTriangle(string _colour,float _Side1Length)
        {
            colour = _colour;
            Side1Length = _Side1Length;
            Side2Length = _Side1Length;
            Side3Length = _Side1Length;
        }

        public double GetArea()
        {
            return (((Math.Sqrt(3))/4)*(Side1Length*Side1Length));
        }
    }
}
