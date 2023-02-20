using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__OnetoHundredPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1'den 100'e kadar sayıları yazdırma.

            // 1'den 100'e kadar çift sayıları yazdırma.

            // For döngüsüyle 1'den 100'e kadar yazdırma
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("***************************");

            // While döngüsüyle 1'den 100'e kadar  yazdırma
            int number2 = 1;
            while (number2 <= 100)
            {
                Console.WriteLine(number2);
                number2++;
            }

            Console.WriteLine("***************************");

            // While döngüsüyle ve if koşuluyla 1'den 100'e kadar çift sayıları yazdırma.
            int number3 = 1;
            while (number3 <= 100)
            {
                int number4 = number3 % 2;
                if (number4 == 0)
                {
                    Console.WriteLine(number3);
                    number3++;
                }
                else
                {
                    number3++;
                }
            }

            Console.WriteLine("***************************");

            //Sadece while döngüsüyle 1'den 100'e kadar çift sayıları yazdırma.
            int number5 = 2;
            while (number5 <= 100)
            {
                Console.WriteLine(number5);
                number5 += 2;
            }





            Console.ReadLine();

        }
    }
}
