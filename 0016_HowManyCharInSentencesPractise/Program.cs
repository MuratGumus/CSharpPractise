using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _0016_HowManyCharInSentencesPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yazdığın cümlede kaç tane harf olduğunu hesaplar

            Console.WriteLine("Please enter sentence");
            string userSentence = Console.ReadLine();
            string lowerUserSentece = userSentence.ToLower();
            string alphabet = "abcdefgğhıijklmnoöprsştuüvyz";
            string[] arrayAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "ı", "i", "j", "k", "l", "m", "n", "m", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };


            string vowel = "aeıioöuü";

            int count = 0;
            int countEveryChar = 0;
            int countVowel = 0;

            for (int i = 0; i < lowerUserSentece.Length; i++)
            {
                if (alphabet.Contains(lowerUserSentece[i]))
                {
                    count++;
                }
            }

            //// Cümlede kaç tane sesli harf olduğunu hesaplar
            for (int i = 0; i < lowerUserSentece.Length; i++)
            {
                if (vowel.Contains(lowerUserSentece[i]))
                {
                    countVowel++;
                }
            }

            //  Hangi harften kaç tane olduğunu hesaplar. B
            for (int i = 0; i < alphabet.Length; i++)
            {
                countEveryChar = 0;

                for (int j = 0; j < lowerUserSentece.Length; j++)
                {
                    if (alphabet[i] == lowerUserSentece[j])
                    {
                        countEveryChar++;
                    }
                }
                if (countEveryChar >= 1)
                {
                    Console.WriteLine($"There are {countEveryChar} {alphabet[i]} in this sentence");
                }
            }
            Console.WriteLine($"There are {count} char in this sentence");
            Console.WriteLine($"There are {countVowel} vowel in this center ");

            Console.ReadLine();
        }
    }
}
