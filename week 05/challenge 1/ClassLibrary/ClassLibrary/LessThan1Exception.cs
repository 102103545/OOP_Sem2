using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LengthException : Exception
    {
        public LengthException()
        {
        }

        public LengthException(int input) : base(input + " is less than 1")
        {
        }
    }
}
