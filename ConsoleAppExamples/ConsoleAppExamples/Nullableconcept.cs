using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExamples
{
    class Nullableconcept
    {
        static void Main(string[] args)
        {
            int? x = null;
            // Nullable<int> x = null;
            int y = x ?? 0;

            Console.WriteLine("x = {0}", x.GetValueOrDefault());
            Console.WriteLine("y ={0}", y);
            Console.ReadLine();
        }
    }
}
