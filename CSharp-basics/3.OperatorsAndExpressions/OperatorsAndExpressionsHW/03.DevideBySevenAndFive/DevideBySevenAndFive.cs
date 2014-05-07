using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DevideBySevenAndFive
{
    class DevideBySevenAndFive
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number % 7 == 0 && number % 5 == 0 ? "Yes, it can be devided by 5 and 7" : "No, it cannot be devided by 5 and 7");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
