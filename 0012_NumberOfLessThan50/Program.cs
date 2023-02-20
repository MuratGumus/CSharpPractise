using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012_NumberOfLessThan50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan 10 tane sayı ister. Bu numaraları 50'den büyük veya küçük olmasına göre ayırır ve toplar.

            int[] numbers = new int[10];

            int lessThan50Count = 0;
            int moreThan50Count = 0;

            int lessThan50Total = 0;
            int moreThan50Total = 0;

            int[] oddnumbers = new int[10];
            int[] evennumbers = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Please enter " + i + ". number from 1 to 100");
                numbers[i - 1] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i - 1] < 50)
                {
                    lessThan50Count++;
                    lessThan50Total += numbers[i - 1];

                }
                else if (numbers[i - 1] >= 50)
                {
                    moreThan50Count++;
                    moreThan50Total += numbers[i - 1];
                }
                if (numbers[i - 1] % 2 == 0)
                {
                    Console.WriteLine(numbers[i - 1] + " is even number");
                    evennumbers[i - 1] = numbers[i - 1];
                }
                else
                {
                    Console.WriteLine(numbers[i - 1] + " is odd number");
                    oddnumbers[i - 1] = numbers[i - 1];
                }

            }
            int avarage = (moreThan50Total + lessThan50Total) / 2;

            Console.WriteLine($"There is/are {lessThan50Count} numbers less than 50");
            Console.WriteLine($"There is/are {moreThan50Count} numbers less than 50");
            Console.WriteLine($"Total of less than 50 number is {lessThan50Total}");
            Console.WriteLine($"Total of more than 50 number is {moreThan50Total}");
            Console.WriteLine(lessThan50Total + moreThan50Total);
            Console.WriteLine("avarage is " + avarage);




            Console.ReadLine();
        }
    }
}
