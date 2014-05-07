using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(gdc(x, y));
        }
        
        static int gdc(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return gdc(y, x % y);
        }
    }
}
