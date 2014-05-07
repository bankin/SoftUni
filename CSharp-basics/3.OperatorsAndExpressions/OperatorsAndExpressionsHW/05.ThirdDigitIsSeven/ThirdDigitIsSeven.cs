using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                number /= 100;
                Console.WriteLine(number % 10 == 7 ? "Yes, it is 7" : "No, it is not 7");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
