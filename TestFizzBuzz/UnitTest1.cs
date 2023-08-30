using TwistedFizzBuzz;
using Xunit.Abstractions;

namespace TestFizzBuzz
{
    public class UnitTest1
    {
        //Empty Name And Divsor input with NumberSet input only. Should print inputed range or set of numbers only.
        [Fact]
        public void Test1()
        {
            //Arrange
            var test = new Twisted
            {
                NumberSet = new List<int> { 4, 25, 67, 23, 44, -81, 5 }
            };

            //Act
            var actual = test.CreateFizzBuzz();

            //Assert
            Assert.Equal(actual, new List<string> { "4", "25", "67", "23", "44", "-81", "5" });
        }

        //Empty Start, End, and NumberSet inputs with Name And Divsor input only. Should print nothing.
        [Fact]
        public void Test2()
        {
            //Arrange
            var test = new Twisted
            {
                NameDivisior = new Dictionary<int, string>
                {
                    { 2, "Fizz"},
                    { 7, "Buzz" }
                }
            };

            //Act
            var actual = test.CreateFizzBuzz();

            //Assert
            Assert.Equal(actual, new List<string>());
        }

        //All empty inputs. Should print nothing.
        [Fact]
        public void Test3()
        {
            //Arrange
            var test = new Twisted();

            //Act
            var actual = test.CreateFizzBuzz();

            //Assert
            Assert.Equal(actual, new List<string>());
        }

        //Basic test with Start and End inputs (1 through 50). Standard FizzBuzz rules (3:Fizz, 5:Buzz).
        [Theory]
        [InlineData(1, "1")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(33, "Fizz")]
        [InlineData(50, "Buzz")]
        public void Test4(int input, string expected)
        {
            //Arrange
            var test = new Twisted
            {
                Start = 1,
                End = 50,
                NameDivisior = new Dictionary<int, string>
                {
                    { 3, "Fizz"},
                    { 5, "Buzz" }
                }
            };

            //Act
            var fizzBuzz = test.CreateFizzBuzz();
            var actual = fizzBuzz[Enumerable.Range(1, 50).ToList().IndexOf(input)];

            //Assert
            Assert.Equal(actual, expected);
        }

        //Basic test with Start and End inputs (1 through 50). Custom FizzBuzz rules (3:Fizz, 5:Buzz, 8:Hello, 9:Bye).
        [Theory]
        [InlineData(12, "Fizz")]
        [InlineData(18, "FizzBye")]
        [InlineData(24, "FizzHello")]
        [InlineData(40, "BuzzHello")]
        [InlineData(45, "FizzBuzzBye")]
        public void Test5(int input, string expected)
        {
            //Arrange
            var test = new Twisted
            {
                Start = 1,
                End = 50,
                NameDivisior = new Dictionary<int, string>
                {
                    { 3, "Fizz"},
                    { 5, "Buzz" },
                    { 8, "Hello" },
                    { 9, "Bye" }
                }
            };

            //Act
            var fizzBuzz = test.CreateFizzBuzz();
            var actual = fizzBuzz[Enumerable.Range(1, 50).ToList().IndexOf(input)];

            //Assert
            Assert.Equal(actual, expected);
        }

        //Basic test with Range inputs. Standard FizzBuzz rules (3:Fizz, 5:Buzz).
        [Theory]
        [InlineData(-9, "Fizz")]
        [InlineData(-2, "-2")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(40, "Buzz")]
        public void Test6(int input, string expected)
        {
            //Arrange
            var test = new Twisted
            {
                NumberSet = new List<int> { 40, 20, 5, 30, 15, -2, 25, 12, -9 },
                NameDivisior = new Dictionary<int, string>
                {
                    { 3, "Fizz"},
                    { 5, "Buzz" }
                }
            };

            //Act
            var fizzBuzz = test.CreateFizzBuzz();
            var actual = fizzBuzz[test.NumberSet.IndexOf(input)];

            //Assert
            Assert.Equal(actual, expected);
        }

        //Basic test with Range inputs. Custom FizzBuzz rules (3:Fizz, 5:Buzz, 8:Hello, 9:Bye).
        [Theory]
        [InlineData(-9, "FizzBye")]
        [InlineData(-1, "-1")]
        [InlineData(32, "Hello")]
        [InlineData(33, "Fizz")]
        [InlineData(45, "FizzBuzzBye")]
        public void Test7(int input, string expected)
        {
            //Arrange
            var test = new Twisted
            {
                NumberSet = new List<int> { 33, 20, 45, 30, 15, -1, 32, 12, -9 },
                NameDivisior = new Dictionary<int, string>
                {
                    { 3, "Fizz"},
                    { 5, "Buzz" },
                    { 8, "Hello" },
                    { 9, "Bye" }
                }
            };

            //Act
            var fizzBuzz = test.CreateFizzBuzz();
            var actual = fizzBuzz[test.NumberSet.IndexOf(input)];

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}