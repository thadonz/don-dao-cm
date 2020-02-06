using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        /// <summary>
        /// Generates an IEnumerable<string> from values 1 to max inclusive. 
        /// Using the given divisorWordPairs, if number is divisible by the divisor 
        /// it returns the word paired with it, else returns the number
        /// </summary>
        public static IEnumerable<string> GenerateFizzBuzzLinq(int max, List<(int, string word)> divisorWordPairs)
        {
            return Enumerable
                .Range(1, max)
                .Select(i => GetFizzBuzzMessage(i, divisorWordPairs));
        }

        /// <summary>
        /// Generates an IEnumerable<string> from values 1 to max inclusive. 
        /// Using the given divisorWordPairs, if number is divisible by the divisor 
        /// it returns the word paired with it, else returns the number
        /// </summary>
        public static IEnumerable<string> GenerateFizzBuzzYield(int max, List<(int, string word)> divisorWordPairs) 
        {
            for (int i = 1; i <= max; i++)
                yield return GetFizzBuzzMessage(i, divisorWordPairs);
        }

        private static void CheckPreconditions(List<(int, string word)> divisorWordPairs) 
        {
            if (divisorWordPairs == null)
                throw new ArgumentNullException("divisorWordPairs cannot be null");

            if (divisorWordPairs.Any(i => i.word == null))
                throw new ArgumentException("divisorWordPairs cannot contain null");
        }

        /// <summary>
        /// Checks if value is divisible by one of the divisors in the divisorWordPairs 
        /// and returns word paired with the divisor else returns the number
        /// </summary>
        public static string GetFizzBuzzMessage(int number, List<(int divisor, string word)> divisorWordPairs)
        {
            CheckPreconditions(divisorWordPairs);

            var matchedWords = divisorWordPairs
                .Where(i => number % i.divisor == 0)
                .Select(i => i.word)
                .ToArray();

            if (matchedWords.Length < 1)
                return number.ToString();

            var output = string.Join("", matchedWords);

            return output.ToString();
        }
    }
}
