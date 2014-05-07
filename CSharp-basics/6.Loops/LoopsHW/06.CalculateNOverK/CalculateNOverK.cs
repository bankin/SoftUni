using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateNOverK
{
    class CalculateNOverK
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int devided = 1;
            int devisor = 1;

            for (int i = 1; i <= (n > k ? n : k); i++)
            {
                if (i <= k)
                {
                    devisor *= i;
                }
                if (i <= n)
                {
                    devided *= i;
                }
            }
            
            Console.WriteLine(devided/devisor);
        }
    }
}
