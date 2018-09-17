using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RightAngleTriangle:Triangle
    {
        public RightAngleTriangle(string _colour,float _Side1Length, float _Side2Length)
        {
            colour = _colour;
            Side1Length = _Side1Length;
            Side2Length = _Side2Length;
            Side3Length = Math.Sqrt((_Side1Length*_Side1Length)+(_Side2Length*_Side2Length));
        }

        public double GetArea()
        {
            return ((Side1Length * Side2Length) / 2);
        }
    }
}
