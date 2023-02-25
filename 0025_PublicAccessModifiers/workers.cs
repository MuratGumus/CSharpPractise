using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0025_PublicAccessModifiers
{
    public class workers
    {
        public int id = 1;
        public string name = "Lewis";
        public string surname = "Hamilton";
        
        public void info()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"surname is {surname}");
        }

        private void test()
        {
            Console.WriteLine("test");
        }
    }
}
