using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NFibonacci
{
    class NFibonacci
    {
        static long fib(int n)
        {
            long a = 1;
            long b = 1;
            long c = 1;

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(fib(n));
        }
    }
}
