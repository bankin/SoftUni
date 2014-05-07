using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.Write("|");
            Console.Write(a.ToString("x").PadRight(10, ' '));
            Console.Write("|");
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|");
            Console.Write(Math.Round(b,2).ToString().PadRight(3,'0').PadLeft(7, ' '));
            Console.Write("|");
            Console.Write(Math.Round(c,3).ToString().PadRight(10, ' '));

        }
    }
}
