using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeOneToN
{
    class RandomizeOneToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] printedNumbers = new bool[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                printedNumbers[i] = false;
            }

            for (int i = 0; i < n; i++)
            {
                int pos = rand.Next(0, n - 1);
                while (printedNumbers[pos])
                {
                    pos = rand.Next(0, n - 1);
                }

                printedNumbers[pos] = true;
                Console.WriteLine(pos+1 + " ");
                

            }
        }
    }
}
