using FizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        private static int max = int.MaxValue;
        private static List<(int, string)> divisorWordPairs = new List<(int, string)> { (3, "fizz"), (5, "buzz") };

        static void Main(string[] args)
        {
            RunFizzBuzzYield();
            //RunFizzBuzzLinq();
        }

        private static void RunFizzBuzzLinq()
        {
            foreach (string word in FizzBuzz.GenerateFizzBuzzLinq(max, divisorWordPairs))
                Console.WriteLine(word);
        }

        private static void RunFizzBuzzYield()
        {
            foreach(string word in FizzBuzz.GenerateFizzBuzzYield(max, divisorWordPairs))
                Console.WriteLine(word);
        }
    }
}
