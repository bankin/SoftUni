using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareFloats
{
    class CompareFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(5.3 - 6.1) < 0.000001);
            Console.WriteLine(Math.Abs(5.00000001 - 5.00000003) < 0.000001);
            Console.WriteLine(Math.Abs(-0.0000007 - 0.00000007) < 0.000001);
            Console.WriteLine(Math.Abs(-4.999999 - (-4.999998)) < 0.000001);
        }
    }
}
