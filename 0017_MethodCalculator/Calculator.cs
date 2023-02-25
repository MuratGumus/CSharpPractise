using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017_MethodCalculator
{
    public class Calculator
    {
        // Addition
        public decimal addition(decimal number1, decimal number2)
        {
            decimal result = number1 + number2;
            return result;
        }

        // Substraction
        public decimal substraction (decimal number1, decimal number2)
        {
            decimal result = number1 - number2;
            return (decimal) result;
        }

        // Division
        public decimal divide (decimal number1, decimal number2)
        {
            decimal result = number1 / number2;
            return (decimal) result;
        }

        // Multiplication
        public decimal multiplication (decimal number1, decimal number2)
        {
            decimal result = number1 * number2;
            return(decimal) result;
        }

        public void Menu()
        {
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Bölme");
            Console.WriteLine("4- Çarpma");
            Console.WriteLine("Please enter your choose");
        }
        

    }
}
