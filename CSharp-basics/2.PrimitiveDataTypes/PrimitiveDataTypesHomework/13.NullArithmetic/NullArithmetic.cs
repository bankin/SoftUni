using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullArithmetic
{
    class NullArithmetic
    {
        static void Main(string[] args)
        {
            int? number = null;
            double? number2 = null;

            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number + 3);
            Console.WriteLine(number2 + 2.45);
        }
    }
}
