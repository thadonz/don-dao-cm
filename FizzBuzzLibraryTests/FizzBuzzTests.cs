using FizzBuzzLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FizzBuzzLibraryTests
{
    public class Tests
    {
        [Test]
        public void MatchesSingleCaseTest()
        {
            var pairs = new List<(int, string)> { (2, "fizz"), (3, "buzz") };

            Assert.AreEqual("fizz", FizzBuzz.GetFizzBuzzMessage(2, pairs));
        }

        [Test]
        public void MatchesMultipleCasesTest()
        {
            var pairs = new List<(int, string)> { (2, "fizz"), (3, "buzz") };

            Assert.AreEqual("fizzbuzz", FizzBuzz.GetFizzBuzzMessage(6, pairs));
        }

        [Test]
        public void NoMatchesTest()
        {
            var pairs = new List<(int, string)> { (6, "fizz"), (7, "buzz") };

            Assert.AreEqual("5", FizzBuzz.GetFizzBuzzMessage(5, pairs));
        }

        [Test]
        public void UsesWordsFromListTest()
        {
            var pairs = new List<(int, string)> { (2, "foo"), (3, "bar") };

            Assert.AreEqual("foobar", FizzBuzz.GetFizzBuzzMessage(6, pairs));
        }

        [Test]
        public void SameDivisorTest()
        {
            var pairs = new List<(int, string)> { (3, "fizz"), (3, "buzz") };

            Assert.AreEqual("fizzbuzz", FizzBuzz.GetFizzBuzzMessage(3, pairs));
        }

        [Test]
        public void EmptyListTest()
        {
            var pairs = new List<(int, string)>();

            Assert.AreEqual("5", FizzBuzz.GetFizzBuzzMessage(5, pairs));
        }

        [Test]
        public void GeneratesSameOrderInOutputAsFoundInListTest()
        {
            var pairs = new List<(int, string)> { (3, "fizz"), (2, "buzz") };

            Assert.AreEqual("fizzbuzz", FizzBuzz.GetFizzBuzzMessage(6, pairs));
        }

        [Test]
        public void NegativeDivisorTest()
        {
            var pairs = new List<(int, string)> { (-2, "buzz") };

            Assert.AreEqual("buzz", FizzBuzz.GetFizzBuzzMessage(6, pairs));
        }

        [Test]
        public void NullListTest()
        {
            Assert.Throws<ArgumentNullException>(() => FizzBuzz.GetFizzBuzzMessage(3, null));
        }       

        [Test]
        public void NullWordInListTest()
        {
            var pairs = new List<(int, string)> { (2, null) };

            Assert.Throws<ArgumentException>(() => FizzBuzz.GetFizzBuzzMessage(2, pairs));
        }

        [Test]
        public void EmptyStringWordTest()
        {
            var pairs = new List<(int, string)> { (2, string.Empty) };

            Assert.AreEqual(string.Empty, FizzBuzz.GetFizzBuzzMessage(2, pairs));
        }

        [Test]
        public void GetFizzBuzzMessageDoesNotReturnNullString()
        {
            var pairs = new List<(int, string)>();

            Assert.IsNotNull(FizzBuzz.GetFizzBuzzMessage(3, pairs));
        }

        [Test]
        public void MaxLessThanOneEnumYieldTest()
        {
            var pairs = new List<(int, string)>();
            var result = FizzBuzz.GenerateFizzBuzzYield(0, pairs);

            Assert.IsNotNull(result);
            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void GeneratesCorrectNumberOfStringsYieldTest()
        {
            int max = 5;
            var pairs = new List<(int, string)>();
            var result = FizzBuzz.GenerateFizzBuzzYield(max, pairs);
            int count = 0;

            Assert.IsNotNull(result);

            foreach (string word in result)
                count++;

            Assert.AreEqual(max, count);
        }

        [Test]
        public void MaxLessThanOneEnumLinqTest()
        {
            var pairs = new List<(int, string)>();
            var result = FizzBuzz.GenerateFizzBuzzLinq(0, pairs);

            Assert.IsNotNull(result);
            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void GeneratesCorrectNumberOfStringsLinqTest()
        {
            int max = 5;
            var pairs = new List<(int, string)>();
            var result = FizzBuzz.GenerateFizzBuzzLinq(max, pairs);
            int count = 0;

            Assert.IsNotNull(result);

            foreach (string word in result)
                count++;

            Assert.AreEqual(max, count);
        }
    }
}
 
 