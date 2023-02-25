using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0025_PublicAccessModifiers
{
    internal class Program
    {

        // Public method, herkes tarafından her yerden erişilen methodtur. Halka açık method olarak tanımlayabilriz. 
        static void Main(string[] args)
        {
            workers worker = new workers();
            worker.info();

            Console.WriteLine(worker.id);
            Console.WriteLine(worker.name);
            worker.surname = "Ham"; // Burada değer atadık.
            Console.WriteLine(worker.surname); // Atanan değeri yazdırdık

            Console.ReadLine();

        }
    }
}
