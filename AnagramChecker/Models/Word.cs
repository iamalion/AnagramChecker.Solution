using System;
using System.Linq;

namespace AnagramChecker.Models
{
    public class Word 
    {
        public bool IsAnagram(string inputtedWordOne, string inputtedWordTwo)
        {
            char[] wordOneChars = inputtedWordOne.ToLower().ToCharArray();
            char[] wordTwoChars = inputtedWordTwo.ToLower().ToCharArray();

            Array.Sort(wordOneChars);
            Array.Sort(wordTwoChars);

            return wordOneChars.SequenceEqual(wordTwoChars);
            
        }
    }
}