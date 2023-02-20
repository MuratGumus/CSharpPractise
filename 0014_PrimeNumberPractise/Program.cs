using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0014_PrimeNumberPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 - 1.000 arasındaki asal sayıları bulur.

            {
                int control = 0;
                int count = 0;
                for (int i = 2; i <= 1000; i++)
                {
                    control = 0;

                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            control++;
                            break;
                        }
                    }
                    if (control == 0)
                    {
                        count++;
                        Console.WriteLine(i + " is prime number");
                    }

                }
                Console.ReadKey();
            }
        }
    }
}
