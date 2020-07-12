using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExamples
{
    class Anonymousmethod
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print print = delegate (int Value)
            {
                Console.WriteLine(" Inside Anonymous Method. Value:{0}", Value);
            };


            print(100);
        }
    }
}
