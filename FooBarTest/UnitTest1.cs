using FizzBazz;
using System;
using Xunit;

namespace FooBarTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(31, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(59, "Buzz")]
        [InlineData(7, "Woof")]
        [InlineData(14, "Woof")]
        [InlineData(49, "Woof")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(21, "FizzWoof")]
        [InlineData(56, "BuzzWoof")]
        [InlineData(35, "FizzBuzzWoof")]
        public void FizzBuzzWoofTest(int input, string output)
        {
            // Arrange
            FizzBuzz sut = new FizzBuzz();

            // Act
            string result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal(output, result);
        }
    }
}