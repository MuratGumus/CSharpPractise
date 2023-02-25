using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0022_PrivateAccessModifiers
{
    internal class Program

        // Private access modifiers (erişim belirleyici) class sınıfında private olarak tanımlanan kodların program.cs'de kullanılması.
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.team);
            Console.WriteLine(student.surname);
            student.teamPrint();
            Console.ReadLine();
        }
    }
}
