using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0015_DatatimePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Doğum tarihini yazdığında kaç yaşında olduğunu hesaplar.
            Console.WriteLine("Please enter your birth year");
            int birthdayYear = Convert.ToInt32(Console.ReadLine());

            int age = DateTime.Now.Year - birthdayYear;
            Console.WriteLine($"You are {age} years old");
      
            Console.ReadLine();

        }
    }
}
