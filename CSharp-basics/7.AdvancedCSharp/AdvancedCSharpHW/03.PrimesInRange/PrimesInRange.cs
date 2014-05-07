using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.PrimesInRange
{
    class PrimesInRange
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

        static List<int> FindPrimesInRange(int startNum,int endNum)
        {
            List<int> result = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (isPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> result = FindPrimesInRange(start, end);
            if (result.Count == 0) { Console.WriteLine("(empty list)"); return; }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + ", ");
            }
            
        }
    }
}
