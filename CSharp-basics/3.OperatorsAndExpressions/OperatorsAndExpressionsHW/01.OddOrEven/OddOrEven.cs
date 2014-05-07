using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input the number you want to check: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
