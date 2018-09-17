using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public int sides { get; set; }
        protected Shape(int pSides)
        {
            sides = pSides;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public virtual string Type()
        {
            return "Unknown";
        }

    }
    
}
