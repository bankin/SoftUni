using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ulong nFact = 1;
            ulong doubleNFact = 1;

            for (uint i = 1; i <= 2*n; i++)
            {                
                if (i <= n)
                {
                    nFact *= i;
                }
                doubleNFact *= i;
            }
            Console.WriteLine(doubleNFact);
            Console.WriteLine(nFact);
            Console.WriteLine(doubleNFact / (nFact*(ulong)(n+1)*nFact));
        }
    }
}
