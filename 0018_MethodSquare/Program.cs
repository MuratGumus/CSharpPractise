using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0018_MethodSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcın girdiği sayının karesinin 25'ten büyük olup olmadığını hesaplar.

            Console.WriteLine("Please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            int squareNumber = square(number);

            if (squareNumber > 25)
            {
                Console.WriteLine("Square of number is bigger than 25");
            }
            else if (squareNumber == 25)
            {
                Console.WriteLine("Square of number is equal 25");
            }
            else
            {
                Console.WriteLine("Square of number is lower than 25");
            }
            Console.ReadLine();

        }

        static int square(int number)
        {
            return number * number;
        }




    }
}

