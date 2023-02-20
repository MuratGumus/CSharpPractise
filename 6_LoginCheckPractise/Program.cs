using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6_LoginCheckPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //While döngüsüyle ID ve parola kontrol etme

            string loginID = "login";
            string loginPassword = "password";

            int count = 3;
            while (true)
            {
                Console.WriteLine("Please enter your Login ID");
                string enteredID2 = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string enteredPassword2 = Console.ReadLine();

                if (enteredID2 == loginID && enteredPassword2 == loginPassword)
                {
                    Console.WriteLine("Succesfull");
                    break;
                }
                else
                {
                    Console.WriteLine("Failed");
                    if (count > 0)
                    {
                        count--;
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("See You");
                        break;
                    }
                }
            }




            Console.ReadLine();


        }
    }
}
