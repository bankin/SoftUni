using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSum
{
    class CalculateSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            int devided = 1;
            int devisor = 1;


            for (int i = 1; i <= n; i++)
            {
                devided *= i;
                devisor = (int)Math.Pow(x, i);
                Console.WriteLine(devided + " / " + devisor);
                sum += (double)devided / (double)devisor;
            }


            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
