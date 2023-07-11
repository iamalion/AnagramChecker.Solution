using System;

namespace AnagramChecker.Models

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string inputWord = Console.ReadLine();

            Word word = new Word();
            string echoedWord = word.EchoWord(inputWord);

            Console.WriteLine("Your word is: " + echoedWord);
            Console.ReadLine();
        }
    }
}