using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week04_project_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string text = System.IO.File.ReadAllText(@"..\..\..\..\words.txt");
            text = text.Replace("\"", "");
            char[] splitchar = { ',' };
            string[] stringArray = null;
            stringArray = text.Split(splitchar);
            List<float> trianglenum = new List<float>();
            for (int i = 1; i < 100; i++)
            {
                float n = i;
                float nt = ((n / 2) * (n + 1));
                trianglenum.Add(nt);
            };
            /*for (int i = 1; i < trianglenum.Count(); i++)
            { Console.WriteLine(trianglenum.ToArray()[i]); };*/
            for (int i = 0; i < stringArray.Length; i++)
            {
                string currentword = stringArray[i];
                int currentsum = 0;
                for (int y = 0; y < currentword.Length; y++)
                {
                    int index = (int)currentword[y] % 32;
                    currentsum += index;
                }
                if (trianglenum.Contains(currentsum))
                {
                    Console.WriteLine(currentword + " is triangular");
                    sum += 1;
                }
            }
            Console.WriteLine("there are " + sum + " triangular words in the file");


            Console.ReadLine();
        }.
        }
    }

