using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0020_MethodBiggerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your 1. Number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your 2. Number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            biggerNumber(number1, number2);

            Console.ReadLine();


        }

        static void biggerNumber(int num1, int num2) // buradaki num1 ve num2, yukarıdaki number1 ve number2'den farklıdır. Aynı değiller.
        {
            if (num1 > num2)
            {
                Console.WriteLine("1. number is bigger than 2. number");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("1. number and 2. number is equal");
            }
            else
            {
                Console.WriteLine("2. number is bigger  than 1. number");
            }
        }
    }
}
