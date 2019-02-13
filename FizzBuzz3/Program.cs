using System;

namespace FizzBuzz3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fb = new FizzBuzz3();
            Console.WriteLine(fb.ExecuteFizzBuzz(args));
            fb.WriteReport();
            Console.ReadKey();
        }
    }
}