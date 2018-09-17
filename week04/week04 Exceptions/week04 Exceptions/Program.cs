using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week04_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int input = 0; 
            try {
                input = int.Parse(Console.ReadLine());
                if (input < 1)
                { throw new LessThan0Exception(input); }
                if (input > 15)
                { throw new GreaterThan15Exception(input); }
                int sum = 0;
                string Input = input.ToString();
                for (int i = 0; i < Input.Length; i++)
                { sum += int.Parse(Input[i].ToString()); }
                Console.WriteLine("sum: " + sum);
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            

        }
    }
}
