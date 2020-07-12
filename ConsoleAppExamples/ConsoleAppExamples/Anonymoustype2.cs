using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppExamples
{
    class Anonymoustype2
    {
        static void Main(string[] args)
        {
            List<Student> sInfo = new List<Student>()
            {
                new Student { Id = 2, Name = "Abhijit", Marks = 300},
                new Student { Id = 3, Name = "Ram", Marks = 340},
                new Student { Id = 4, Name = "Jayesh", Marks = 310},
                new Student { Id = 5, Name = "Nagraj", Marks = 320},
            };


            var result = from s in sInfo
                         select new { StudentName = s.Name, StudentMarks = s.Marks };

            Console.WriteLine("********** Result **********");
            foreach (var item in result)
            {
                Console.WriteLine("Name: {0}, Marks: {1}", item.StudentName, item.StudentMarks);
            }
            Console.ReadLine();
        }

    }


    class Student
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}
