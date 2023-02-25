using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023_ProtectedAccessModifiers
{
    // First Class'tan sonra ":" yapıp Second Class yazdığımızda First Class, Second Class' miras olarak devralır. Böylelikle Second Class içerisinde tanımlanan ve miras yoluyla aktarılabilen methodlar first class tarafından da erişelebilir.

    public class FirstClass : SecondClass  
    {
        public FirstClass()
        {
            protectedMethod();
        }
    }
}
