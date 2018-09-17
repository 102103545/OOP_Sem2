using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week02_primefibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the sum of the first 8 numbers that are prime and also part of the fibbonaci sequence
            //bonus:find the 1st number greater than 2 that is a fibonnaci number and the result of a factorial
            List<Int64> fibonacci =new List<Int64>();
            List<Int64> primes = new List<Int64>();
            List<Int64> factorials = new List<Int64>();

            Int64 fib1 = 0;
            Int64 fib2 = 1;
            for (Int64 i = 0; i < 1000; i++)
            {
                fibonacci.Add(fib2);
                //Console.WriteLine("fib "+i+" = " +fib2);
                Int64 sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = sum;
            }

            for (Int64 i = 2; i < 50000; i++)
            {
                bool isprime = true;
                for (Int64 y = i-1;y>1;y--)
                {
                    if (i % y == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime)
                {
                    //Console.WriteLine(i + " is prime");
                    primes.Add(i);
                }

            }
            for (int i = 1; i < 100; i++)
            {
                Int64 factorial = 1;
                for (int y = i; y > 0; y--)
                { factorial *= y; }
                fact
            }

            Int64[] primearray= primes.ToArray();
            Int64[] fibarray = fibonacci.ToArray();
            List<Int64> both = new List<Int64>();

                for (Int64 i = 0; i < 1000; i++)
                {
                    if (primearray.Contains(fibarray[i]))
                    {
                    Console.WriteLine(fibarray[i] + " is prime and fib");
                    both.Add(fibarray[i]);
                    }
                }
            Console.WriteLine(both.Sum());
            Console.ReadLine();
        }
    }
}
