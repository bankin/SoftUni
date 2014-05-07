using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Please input p: ");
                int p = 3;
                int q = 24;
                int k = 3;

                for (int i = 0; i < k; i++)
                {
                    int mask1 = 1 << (p + i);
                    int bit1 = number & mask1;
                    bit1 >>= (p + i);
                    bit1 <<= (q + i);

                    int mask2 = 1 << (q + i);
                    int bit2 = number & mask2;
                    bit2 >>= (q + i);
                    bit2 <<= (p + i);

                    if (bit1 == 0)
                    {
                        number &= ~(1 << (q + i));
                    }
                    else
                    {
                        number |= bit1;
                    }

                    if (bit2 == 0)
                    {
                        number &= ~(1 << (p + i));
                    }
                    else
                    {
                        number |= bit2;
                    }
                }

                Console.WriteLine("The result is " + number);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
