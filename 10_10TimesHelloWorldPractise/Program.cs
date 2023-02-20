using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10TimesHelloWorldPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Konsolda 10 defa "Hello World" yazdırır

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "." +"Hello World");
            }
            Console.ReadLine();
        }
    }
}
