using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.Write("Input your birthdate separated with `dash` :");
            string date = Console.ReadLine();
            DateTime bday = DateTime.Parse(date);
            DateTime today = DateTime.Today.AddYears(10);
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) { age--; }
            Console.WriteLine("You will be " + age + " years old");
        }
    }
}
