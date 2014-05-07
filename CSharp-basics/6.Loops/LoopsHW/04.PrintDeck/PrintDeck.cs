using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintDeck
{
    class PrintDeck
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0;  j < 4;  j++)
                {
                    switch (i)
                    {
                        case 11: Console.Write("J"); break;
                        case 12: Console.Write("Q"); break;
                        case 13: Console.Write("K"); break;
                        case 14: Console.Write("A"); break;
                        default: Console.Write(i); break;
                    }

                    switch (j)
                    {
                        case 0: Console.Write("♣ "); break;
                        case 1: Console.Write("♦ "); break;
                        case 2: Console.Write("♥ "); break;
                        case 3: Console.Write("♠ "); break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
