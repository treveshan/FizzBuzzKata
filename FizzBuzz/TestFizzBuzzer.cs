using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class TestFizzBuzzer
    {
        [Test]
        public void GetFizzBuzz_GivenInputOf_1_ShouldReturn_1()
        {
            // Arrange
            const int input = 1;
            const string expected = "1";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_3_ShouldReturn_Fizz()
        {
            // Arrange
            const int input = 3;
            const string expected = "Fizz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_2_ShouldReturn_Fizz()
        {
            // Arrange
            const int input = 2;
            const string expected = "2";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_4_ShouldReturn_Fizz()
        {
            // Arrange
            const int input = 4;
            const string expected = "4";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_5_ShouldReturn_Buzz()
        {
            // Arrange
            const int input = 5;
            const string expected = "Buzz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_6_ShouldReturn_Fizz()
        {
            // Arrange
            const int input = 6;
            const string expected = "Fizz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_9_ShouldReturn_Fizz()
        {
            // Arrange
            const int input = 9;
            const string expected = "Fizz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void GetFizzBuzz_GivenInputOf_10_ShouldReturn_Buzz()
        {
            // Arrange
            const int input = 10;
            const string expected = "Buzz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_15_ShouldReturn_FizzBuzz()
        {
            // Arrange
            const int input = 15;
            const string expected = "FizzBuzz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzz_GivenInputOf_30_ShouldReturn_FizzBuzz()
        {
            // Arrange
            const int input = 30;
            const string expected = "FizzBuzz";
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var result = fizzBuzzer.GetFizzBuzz(input);

            // Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void GetFizzBuzzList_GivenNumberOfEntriesIs_1_ShouldReturn_ListWithCount_1()
        {
            // Arrange
            const int numberOfEntries = 1;
            const int expected = 1;
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var fizzBuzzList = fizzBuzzer.GetFizzBuzzList(numberOfEntries);

            // Assert
            Assert.AreEqual(expected, fizzBuzzList.Count);

        }

        [Test]
        public void GetFizzBuzzList_GivenNumberOfEntriesIs_2_ShouldReturn_ListWithCount_2()
        {
            // Arrange
            const int numberOfEntries = 2;
            const int expected = 2;
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var fizzBuzzList = fizzBuzzer.GetFizzBuzzList(numberOfEntries);

            // Assert
            Assert.AreEqual(expected, fizzBuzzList.Count);

        }

        [Test]
        public void GetFizzBuzzList_GivenNumberOfEntriesIs_20_ShouldReturnFizzBuzzList()
        {
            // Arrange
            const int numberOfEntries = 20;
            var expected = new List<string>
           {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz",
                "16",
                "17",
                "Fizz",
                "19",
                "Buzz",
           };
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var fizzBuzzList = fizzBuzzer.GetFizzBuzzList(numberOfEntries);

            // Assert
            CollectionAssert.AreEqual(expected, fizzBuzzList);

        }

        [Test]
        public void GetFizzBuzzList_GivenNumberOfEntriesIs_Many_ShouldReturn_ListWithCount_Many()
        {
            // Arrange
            const int numberOfEntries = 3;
            const int expected = 3;
            var fizzBuzzer = CreateFizzBuzzer();

            // Act
            var fizzBuzzList = fizzBuzzer.GetFizzBuzzList(numberOfEntries);

            // Assert
            Assert.AreEqual(expected, fizzBuzzList.Count);

        }


        private static FizzBuzzer CreateFizzBuzzer()
        {
            return new FizzBuzzer();
        }
    }
}