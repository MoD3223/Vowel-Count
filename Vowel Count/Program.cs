using System;
using System.Collections.Generic;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();
            int vowelsCount = 0;

            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < inputString.Length; i++)
            {
                if (vowels.Contains(inputString[i]))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine("The number of vowels is: " + vowelsCount);
            Console.ReadKey();
        }
    }
}
