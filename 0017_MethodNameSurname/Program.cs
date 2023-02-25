using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0017_MethodNameSurname
{

    // Konsola isim soyismi yazdıran bir method.
    internal class Program
    {
        static void Main(string[] args) // Burası kodun yazıldığı yer
        {
            string UsersNameSurname = NameSurname("Lewis", "Hamilton"); //1. Burada yazılan kelimeler 2. kısma gönderilir.
            Console.WriteLine(UsersNameSurname); //3. İkinci kısımda düzenlenen kelimeleri çağırır.
            Console.ReadLine();
        }

        static string NameSurname(string name, string surname) // Burası METHOD'un tanımlandığı yer
        {
            return name + " " + surname; //2. Birinciden gelen kelimelerin konsolda nasıl yazılacağı ayarlanır. 3.kısım tarafından çağrıldığında konsola yazdırır.
            // return'dan sonra yazılan hiçbir kod çalışmaz. Return ile birlikte method sona erer.
        }
    }
}
