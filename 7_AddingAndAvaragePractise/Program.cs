using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AddingAndAvaragePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1'den başlayıp kullanıcının girdiği sayıya kadar toplar ve kullanıcının girdiği sayıya bölerek ortalamayı alır. Bu örnekteki asıl amaç 1'den başlayarak girilen sayıya kadar toplamak, for döngüsüyle toplama yapmaktadır.

            Console.WriteLine("Please enter number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            for (int i = 0; i <= number1; i++)
            {
                total = total + i;
            }
            Console.WriteLine("Your total is " + total);


            if ((total/number1)>50)
            {
                Console.WriteLine("Your avarage is bigger than 50");
            }
            else if ((total/number1) == 50)
            {
                Console.WriteLine("Your avarage is 50");
            }
            else
            {
                Console.WriteLine("Your avarage is lower than 50");
            }
            Console.ReadLine();
        }
    }
}
