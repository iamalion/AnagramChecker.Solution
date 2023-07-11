using System;
using AnagramChecker.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnagramChecker
{
    class Program
    {   
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string wordOne = Console.ReadLine();
            Console.WriteLine("Enter a second word to check if it's an anagram of the first:");
            string wordTwo = Console.ReadLine();

            bool result = IsAnagram(wordOne, wordTwo);

            if (result)
            {
                Console.WriteLine($"Hooray! '{wordOne}' and '{wordTwo}' are anagrams!");
            } 
            else{
                Console.WriteLine($"Ah shucks. '{wordOne}' and '{wordTwo}' are not anagrams.");
            }
            Console.ReadLine();
        }
        static bool IsAnagram(string wordOne, string wordTwo)
        {
            char[] wordOneChars = wordOne.ToLower().ToCharArray();
            char[] wordTwoChars = wordTwo.ToLower().ToCharArray();

            Array.Sort(wordOneChars);
            Array.Sort(wordTwoChars);

            return Enumerable.SequenceEqual(wordOneChars, wordTwoChars);

        }
    }
}