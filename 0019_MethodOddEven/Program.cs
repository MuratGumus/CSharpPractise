using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0019_MethodOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());



            int oddOrEven = OddEven(number);
            if (oddOrEven==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadLine();
        }

        static int OddEven(int number)
        {
            return number%2;
        }
    }
}
