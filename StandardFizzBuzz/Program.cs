using System;
using TwistedFizzBuzz;

namespace StandardFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Twisted twisted = new Twisted
            {
                Start = 1,
                End = 100,
                NameDivisior = new Dictionary<int, string>
                {
                    { 3, "Fizz"},
                    { 5, "Buzz" }
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
