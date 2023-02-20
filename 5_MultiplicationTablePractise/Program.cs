using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MultiplicationTablePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çarpım tablosu

            // For döngüsüyle 1-10 arası sayılara göre çarpım tablosu hazırlanır.


            for (int number1 = 1; number1 <= 10; number1++)
            {
                for (int number2 = 1; number2 <= 10; number2++)
                {
                    Console.WriteLine(number1 + "*" + number2 + "=" + number1 * number2);
                }
                Console.WriteLine("********************");

            }
            Console.ReadLine();
        }
    }
}
