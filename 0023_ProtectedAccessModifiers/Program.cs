using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023_ProtectedAccessModifiers
{
    internal class Program
    {

        // Protected method private method gibidir. Sadece kendisinin tanımlandığı class'tan erişebilir. Ancak pricate method'dan farklı olarak aynı zamanda kendisini miras alan class'ların içerisinden de erişilebilir. 

        // Bu örnekte firstClass, secondClass'ı miras olarak almaktadır.
        static void Main(string[] args)
        {
            SecondClass secondClass = new SecondClass();

            Console.ReadLine();

        }
    }
}
