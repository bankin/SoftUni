using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input a side: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Please input b side: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Please input h side: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Area = "+((a+b)*h/2));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
