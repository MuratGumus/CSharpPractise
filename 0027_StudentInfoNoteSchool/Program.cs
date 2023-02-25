using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0027_StudentInfoNoteSchool
{
    class Program
    {

        //  Kullanıcının seçimine göre konsol ekranına ilgili seçimle ilgili dönütleri yazdırır.
        static void Main(string[] args)
        {
            bool control = true;
            Students student = new Students(1, "Albert", "Eintein", 100, 100, 100, "Oxford");

            Console.WriteLine("Welcome");

            
            while (control) // while döngüsü ile kullanıcı çıkış yapana kadar yeniden seçim ekranına dönmesi sağlanıyor.
            {
                option();
                string chooseOfUser = Console.ReadLine();

                switch (chooseOfUser)
                {
                    case "1":
                        student.studentInfo();
                        break;

                    case "2":
                        double Avarage = student.noteAvarage();
                        Console.WriteLine(Avarage);
                        break;
                    case "3":
                        student.schoolName();
                        break;
                    case "4":
                        control = false; // buradaki false ile birlikte while döngüsü kırılır
                        break;

                }
            }

            Console.ReadLine();
        }

        static void option()
        {
            Console.WriteLine("1- Student Info");
            Console.WriteLine("2- Note Avarage");
            Console.WriteLine("3- School Name");
            Console.WriteLine("4- Quit");
        } // Bu methodda seçim ekranı yazılı. Yukarıda yazılan kodun okunurluğunun azalması için burada yazıldı.
    }
}
