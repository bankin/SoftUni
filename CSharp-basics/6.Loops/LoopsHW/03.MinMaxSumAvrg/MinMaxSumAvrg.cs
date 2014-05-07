using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAvrg
{
    class MinMaxSumAvrg
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0, min = 0, sum = 0;            
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = current;
                    max = current;
                    sum = current;
                }
                else
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    if (current < min)
                    {
                        min = current;
                    }
                    sum += current;
                }
            }

            Console.WriteLine("min = " + min);
            Console.WriteLine("max = " + max);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avrg = {0:0.00}", (double)sum/(double)n);
        }
    }
}
