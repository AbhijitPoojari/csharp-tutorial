using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExamples
{
    class DynamictypeConcepts
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Dynamic Type Concept");
            dynamic i = 100;
            Console.WriteLine("i value: {0}, type: {1}", i, i.GetType());
            dynamic j = "Welcome to Tutlane";
            Console.WriteLine("j value: {0}, type: {1}", j, j.GetType());
            dynamic k = true;
            Console.WriteLine("k value: {0}, type: {1}", k, k.GetType());
            dynamic l = 20.50;
            Console.WriteLine("l value: {0}, type: {1}", l, l.GetType());
            Console.ReadLine();
        }
    }
}
