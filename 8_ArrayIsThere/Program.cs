using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ArrayIsThere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 6, 5, 4, 6, 4,7 };
            int howMany = 0;

            Console.WriteLine("Please enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    howMany++;
                }
            }
            if (howMany ==0)
            {
                Console.WriteLine("There is not this number");
            }
            else
            {
                Console.WriteLine($"There is/are {howMany}" );
            }
            Console.ReadLine();
        }
    }
}
