using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.Write(0);
                Console.WriteLine(1);
            }
            else
            {
                int a = 0;
                int b = 1;
                Console.Write("0 1 ");
                for (int i = 0; i < n - 2; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }
            }
        }
    }
}
