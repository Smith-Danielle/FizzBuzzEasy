using System;
using TwistedFizzBuzz;

namespace CustomFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Twisted twisted = new Twisted
            {
                Start = -20,
                End = 127,
                NameDivisior = new Dictionary<int, string>
                {
                    { 5, "Fizz"},
                    { 9, "Buzz" },
                    { 27, "Bar" }
                }
            };

            var standard = twisted.CreateFizzBuzz();

            foreach (var item in standard)
            {
                Console.WriteLine(item);
            }
        }
    }
}