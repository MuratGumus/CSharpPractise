using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0011_XTimesXCwPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcının girdiği metni kullanıcının istediği sayıda yazdırır.

            Console.WriteLine("Please enter the string");
            string string1 = Console.ReadLine();

            Console.WriteLine("How many times do you want it written");
            int times1 = int.Parse(Console.ReadLine());

            for (int times = 1; times <= times1; times++)
            {
                Console.WriteLine(times + ". times " + string1);
            }

            Console.ReadLine(); 
        }
    }
}
