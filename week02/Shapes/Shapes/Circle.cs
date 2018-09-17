using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle:Shape
    {
        public double Radius { get; }
        public Circle(double pRadius) : base (1)
        {
            Radius = pRadius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * (Radius);
        }
    }
}
