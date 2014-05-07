using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nFact = 1;
            int kFact = 1;
            int nMinusKFact = 1;

            for (int i = 1; i <= (n > k ? n : k); i++)
            {
                if (i <= k)
                {
                    kFact *= i;
                }
                if (i <= n)
                {
                    nFact *= i;
                }
                if (i <= (n-k))
                {
                    nMinusKFact *= i;
                }
            }

            Console.WriteLine(nFact / (kFact*nMinusKFact));
        }
    }
}
