using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write(a + " ");
                    if (b > c)
                    {
                        Console.WriteLine(b + " " + c);
                    }
                    else { Console.WriteLine(c + " " + b); }
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                    if (a > c)
                    {
                        Console.WriteLine(a + " " + c);
                    }
                    else { Console.WriteLine(c + " " + a); }
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}
