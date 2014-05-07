using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersOneToN
{
    class NumbersOneToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(1);
            for (int i = 2; i < n; i++)
            {
                Console.Write(" " + i);
            }
        }
    }
}
