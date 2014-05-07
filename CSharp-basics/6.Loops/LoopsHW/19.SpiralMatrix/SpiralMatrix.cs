using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)            
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            char dir = 'r';
            if (n >= 1 && n <= 100)
            {
                int[,] mass = new int[n, n];
                for (int st = 1; st <= n * n; st++)
                {
                    if (dir == 'r' && (j > n - 1 || mass[i, j] != 0))
                    {
                        dir = 'd';
                        j--;
                        i++;
                    }
                    if (dir == 'd' && (i > n - 1 || mass[i, j] != 0))
                    {
                        dir = 'l';
                        i--;
                        j--;
                    }
                    if (dir == 'l' && (j < 0 || mass[i, j] != 0))
                    {
                        dir = 'u';
                        j++;
                        i--;
                    }
                    if (dir == 'u' && (i < 0 || mass[i, j] != 0))
                    {
                        dir = 'r';
                        i++;
                        j++;
                    }
                    mass[i, j] = st;

                    switch (dir)
                    {
                        case 'u': i--;
                            break;
                        case 'd': i++;
                            break;
                        case 'l': j--;
                            break;
                        case 'r': j++;
                            break;
                    }

                }
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        Console.Write("{0,2}\t", mass[r, c]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error. Bad input!");
            }
        }
    }
}
