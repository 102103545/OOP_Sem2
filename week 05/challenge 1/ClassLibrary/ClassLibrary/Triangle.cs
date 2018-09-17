using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Triangle:Shape
    {
        public double Side1Length { get; set; }
        public double Side2Length { get; set; }
        public double Side3Length { get; set; }

        public double GetPerimeter()
        {
            return (Side1Length+Side2Length+Side3Length);
        }
    }
}
