using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OddEvenArrayPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane sayı girmesini ister. Bu sayıları tek ve çift olarak ayırır. Tek sayıların adetini ve çift sayıların adetini hesaplar. Tek sayıların toplamının mı yoksa çift sayıların toplamının mı daha fazla olduğunu hesaplar

            int[] numbers = new int[10];

            int howManyOdd = 0;
            int howManyEven = 0;

            int oddTotal = 0;
            int evenTotal = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter " + (i + 1) + ". number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    howManyEven++;
                    evenTotal += numbers[j];
                }
                else
                {
                    howManyOdd++;
                    oddTotal += numbers[j];
                }
            }
            Console.WriteLine("There are "+howManyOdd + "odd numbers");
            Console.WriteLine("There are "+ howManyEven+ "even numbers");

            Console.WriteLine("Total of od numbers is " + oddTotal);
            Console.WriteLine("Total of even numbers is "+ evenTotal);
            if (oddTotal>evenTotal)
            {
                Console.WriteLine("Total of odd numbers is bigger than total of even numbers");
            }
            else if (evenTotal>oddTotal)
            {
                Console.WriteLine("Total of even numbers is bigger than total of odd numbers");
            }
            else
            {
                Console.WriteLine("Total of even numbers and total of odd numbers is equal");
            }


            Console.ReadLine();
        }
    }
}
