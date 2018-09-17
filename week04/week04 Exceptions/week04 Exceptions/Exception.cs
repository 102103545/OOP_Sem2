using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week04_Exceptions
{
    class LessThan0Exception:Exception
    {
        public LessThan0Exception()
        {
        }

        public LessThan0Exception(int input): base(input+" is less than or equal to 0")
        {
        }
    }

    class GreaterThan15Exception : Exception
    {
        public GreaterThan15Exception()
        {
        }

        public GreaterThan15Exception(int input): base(input+" is greater than 15")
        {
        }
    }
}
