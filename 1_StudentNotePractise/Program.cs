using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StudentNotePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrencinin Notunu Hesaplar

            // Öncelikle kullanıcıdan öğrencinin 3 notunu girmesi istenir. Daha sonra bu 3 notun ortalaması alınarak hangi notu aldığı konsola yazdırılır.

            Console.WriteLine("Please Enter Student's First Note");
            int note1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Student's Second Note");
            int note2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Student's Third Note");
            int note3 = Convert.ToInt32(Console.ReadLine());

            int noteAverage = (note1 + note2 + note3) / 3;


            if (noteAverage >= 80)
            {
                Console.WriteLine("Your note is A");
            }

            else if (noteAverage > 60 && noteAverage < 80)
            {
                Console.WriteLine("Your note is B");
            }

            else if (noteAverage >= 40 && noteAverage < 60)
            {
                Console.WriteLine("Your note is C");
            }
            else
            {
                Console.WriteLine("Your note is F");
            }
            Console.ReadLine();
        }
    }
}
