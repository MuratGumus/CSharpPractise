using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BodyMassIndexPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vücut kitle endeksini hesaplar.

            // Kullanıcının boy uzunluğu ile kilosunu öğrendikten sonra vücut kitle endeksini hesaplar.

            Console.WriteLine("How tall you are?");
            double tall = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many kilos are you?");
            int kilos = Convert.ToInt32(Console.ReadLine());

            double bodyMassIndex = kilos / (tall * tall);

            if (bodyMassIndex <= 18)
            {
                Console.WriteLine("Slim");
            }
            else if (bodyMassIndex <= 25 && bodyMassIndex > 18)
            {
                Console.WriteLine("Normal");
            }
            else if (bodyMassIndex > 25)
            {
                Console.WriteLine("Fat");
            }

            Console.ReadLine();
        }
    }
}
