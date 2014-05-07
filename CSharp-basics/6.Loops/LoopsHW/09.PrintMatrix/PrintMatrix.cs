using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n+i; j++)
                {
                    Console.Write(j+1 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
