using System;

namespace FizzBuzz2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new FizzBuzz2().ExecuteFizzBuzz(args));
            Console.ReadKey();
        }
    }
}