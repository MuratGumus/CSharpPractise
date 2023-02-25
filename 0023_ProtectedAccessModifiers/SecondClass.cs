using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _0023_ProtectedAccessModifiers
{
    public class SecondClass
    {
        private void priveMethod()
        {
            Console.WriteLine("Private method is working");

        }
        protected void protectedMethod()
        {
            Console.WriteLine("Protected method is working");
        }
    }
}
