using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger number = 1;

            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
            int zeros = 0;
            while (number % 5 == 0)
            {
                zeros++;
                number /= 5;
            }


            Console.WriteLine(zeros);
        }
    }
}
