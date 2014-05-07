using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            int[] counts = new int[26];

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                counts[(int)(input[i][0] - 'a')]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    Console.WriteLine((char)(i + 'a') + " -> " + counts[i]);
                }
            }
        }
    }
}
