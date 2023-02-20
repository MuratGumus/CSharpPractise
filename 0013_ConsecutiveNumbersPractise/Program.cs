using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0013_ConsecutiveNumbersPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan başlangıç ve bitiş değeri ile artış oranını ister. Başlangıç değerinden başlayarak bitiş değerine kadar olan artış değerindeki sayıları yazdırır.

            Console.WriteLine("Please enter starting number");
            int startingNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter stopping number");
            int stoppingNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter amount of increase"); // artış miktarı
            int increase = Convert.ToInt32(Console.ReadLine());

            for (int i = startingNumber; i <= stoppingNumber; i += increase)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
