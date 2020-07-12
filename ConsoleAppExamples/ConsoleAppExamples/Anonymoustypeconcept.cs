using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExamples
{
    class Anonymoustypeconcept
    {
        static void Main(string[] args)
        {
            var user = new
            {
                Id = 1,
                Name = "Abhijit",
                City = "Mumbai",
                IsActive = true,
                jobInfo = new { Designation = "Lead", Location = "Navi Mumbai" }  //nested anonymous type
            };

            Console.WriteLine("Id :" + user.Id);
            Console.WriteLine("Name :" + user.Name);
            Console.WriteLine("City :" + user.City);
            Console.WriteLine("IsActive :" + user.IsActive);
            Console.WriteLine("Designation :" + user.jobInfo.Designation);
            Console.WriteLine("Location :" + user.jobInfo.Location);
            GetDetails(user);
        }

        static void GetDetails(dynamic user)
        {
            Console.WriteLine("\n");
            Console.WriteLine("This is accessing anonymous object from method pass it as Dynamic Type");
            Console.WriteLine("Id:" + user.Id);
            Console.WriteLine("Name:" + user.Name);
            Console.WriteLine("IsActive:" + user.IsActive);
        }
    }
}
