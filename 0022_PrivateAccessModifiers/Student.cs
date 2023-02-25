using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0022_PrivateAccessModifiers
{
    public class Student
    {
        private int id = 1;
        private string name = "Lewis";
        public string surname = "Hamilton";
        public string team = "Mercedes";

        private void nameSurnamePrint()
        {
            Console.WriteLine($"name is {name}, surname is {surname} ");
        }

        public void teamPrint()
        {
            Console.WriteLine($"Team is {team}");
        }
    }

}
