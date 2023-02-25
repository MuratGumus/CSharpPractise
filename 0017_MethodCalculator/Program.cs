using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017_MethodCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Calculator Calcu = new Calculator();
            Calcu.Menu(Calcu);


            Console.ReadLine();
        }
    }
}
