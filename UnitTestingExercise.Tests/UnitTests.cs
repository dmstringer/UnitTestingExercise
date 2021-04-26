using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(1, 3, 5, 9)]
        [InlineData(10, 20, 30, 60)]
        [InlineData(-10, 20, -30, -20)]
        [InlineData(5, 25, 35, 65)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods theTest = new UnitTestMethods();
            //Act
            int actual = theTest.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 3, 7)]
        [InlineData(100, 20, 80)]
        [InlineData(-10, -20, 10)]
        [InlineData(25, 0, 25)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods theTest = new UnitTestMethods();
            //Act
            int actual = theTest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 3, 9)]
        [InlineData(10, 12, 120)]
        [InlineData(-10, 2, -20)]
        [InlineData(25, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods theTest = new UnitTestMethods();
            //Act
            int actual = theTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 1, 100)]
        [InlineData(30, 3, 10)]
        [InlineData(10, 5, 2)]
        [InlineData(-10, 2, -5)]
        [InlineData(25, 25, 1)]
        [InlineData(25, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods theTest = new UnitTestMethods();
            //Act
            int actual = theTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetHello()
        {
            // Arrange
            UnitTestMethods getHello = new UnitTestMethods();

            // Act
            string actual = getHello.SayHello();

            // Assert
            Assert.Equal("Hello!", actual);
        }

        [Fact]
        public void DivisableBy5Under100()
        {
            // Arrange
            UnitTestMethods theTest = new UnitTestMethods();
            int[] odds = {
                0, 5, 10, 15, 20, 25, 30, 35, 40, 45,
                50, 55, 60, 65, 70, 75, 80, 85, 90, 95   
            };

            // Act
            int[] actual = theTest.PositiveDivisableBy5Under100();

            // Assert
            Assert.Equal(odds, actual);
        }
    }
}
