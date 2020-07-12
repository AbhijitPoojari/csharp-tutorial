using System;

namespace ConsoleAppExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var Concept");
            var i = 100;

            Console.WriteLine("i value: {0}, type: {1}", i, i.GetType());

            var j = "Welcome to Tutlane";

            Console.WriteLine("j value: {0}, type: {1}", j, j.GetType());

            var k = true;

            Console.WriteLine("k value: {0}, type: {1}", k, k.GetType());

            var l = 20.50;

            Console.WriteLine("l value: {0}, type: {1}", l, l.GetType());

            Console.ReadLine();
        }
    }
}
