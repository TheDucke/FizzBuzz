using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(new FizzBuzz().ExecuteFizzBuzz(args));
            Console.ReadKey();
        }
    }
}