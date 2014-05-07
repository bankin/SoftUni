using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Nikolay";
            string lastName = "Bankin";
            byte age = 19;
            char gender = 'm';
            string personalId = "8306112507";
            string uniqueEmployeeNumber = "27569999";

            Console.WriteLine("Name : " + firstName + " " +lastName);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + (gender == 'm' ? "Male" : "Female"));
            Console.WriteLine("Personal ID : " + personalId);
            Console.WriteLine("Unique Employee Number : " + uniqueEmployeeNumber);
        }
    }
}
