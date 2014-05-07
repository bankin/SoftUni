using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        static bool isPrime(BigInteger n)
        {
            if (n == 0) { return false; }
            if (n == 1) { return false; }
            for (BigInteger i = 2; i < n; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }

        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(n));
        }
    }
}
