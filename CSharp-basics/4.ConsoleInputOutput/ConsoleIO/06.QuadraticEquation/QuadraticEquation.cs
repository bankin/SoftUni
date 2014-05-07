using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Every x which belongs to R");
                    }
                    else
                    {
                        Console.WriteLine("No real roots");
                    }
                }
                else
                {
                    Console.WriteLine("x = " + (-c/b));
                }
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("No real roots");
                }
                else if (d == 0)
                {
                    Console.WriteLine("x1,2 = " + (-b/(2*a)));
                }
                else
                {
                    Console.WriteLine("x1 = " + ((-b + Math.Sqrt(d)) / (2 * a)));
                    Console.WriteLine("x2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));
                }
            }
        }
    }
}
