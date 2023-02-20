using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_MiniATMApplicationPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mini ATM Uygulamasıdır

            // Kullanıcıdan bir tuşa basmasa istenilecek. Kullanıcının bastığı tuşa göre atm işlemi gerçekleşecek.

            Console.WriteLine("Welcome to ATM Application");
            Console.WriteLine("1- Learning Money");
            Console.WriteLine("2- Wanting Money");
            Console.WriteLine("3- Adding Money");
            Console.WriteLine("4- Quit");
            Console.WriteLine("Please Enter Your Preference");
            string preference = Console.ReadLine();
            int havingMoney = 10000;

            if (preference == "1")
            {
                Console.WriteLine("You have a " + havingMoney + "TL");
            }
            else if (preference == "2")
            {
                Console.WriteLine("Please Enter Money You Want to Withdraw");
                int wantingMoney = Convert.ToInt32(Console.ReadLine());
                if (wantingMoney < havingMoney)
                {
                    havingMoney = havingMoney - wantingMoney;
                    Console.WriteLine("Process Completed. You Still Have a " + havingMoney + "TL");
                }
                else
                {
                    Console.WriteLine("You Do Not Have a Enough Money");
                }

            }
            else if (preference == "3")
            {
                Console.WriteLine("Please Enter Money You Want to Add");
                int addingMoney = Convert.ToInt32(Console.ReadLine());
                havingMoney = havingMoney + addingMoney;
                Console.WriteLine("Process Completed. You Still Have a " + havingMoney + "TL");
            }
            else if (preference == "4")
            {
                Console.WriteLine("See You Again!");
            }
            else
            {
                Console.WriteLine("Please Press The Correct Key");
            }

            Console.ReadLine();
        }
    }
}
