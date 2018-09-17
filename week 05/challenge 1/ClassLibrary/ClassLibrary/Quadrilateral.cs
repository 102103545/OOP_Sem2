using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Quadrilateral : Shape
    {

       public int Side1Length { get; set; }
       public int Side2Length { get; set; }
       public int Side3Length { get; set; }
       public int Side4Length { get; set; }

        public int GetPerimeter() { return (Side1Length + Side2Length + Side3Length + Side4Length); }

       

        
    }
}

