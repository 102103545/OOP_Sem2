using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double pLength, double pWidth):base(4)
        {
            Length = pLength;
            Width = pWidth;
        }
        public double Length { get;}
        public double Width { get; }
         public override double Area()
        {
            return Length * Width;
        }
         public override double Perimeter()
        {
            return 2*(Length + Width);
        }
    }
}
