using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitExchangeAdv
{
    class BitExchangeAdv
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                uint number = uint.Parse(Console.ReadLine());
                Console.Write("Please input p: ");
                int p = int.Parse(Console.ReadLine());
                Console.Write("Please input q: ");
                int q = int.Parse(Console.ReadLine());
                Console.Write("Please input k: ");
                int k = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < k; i++)
                {
                    uint mask1 = (uint)1 << (p + i);
                    uint bit1 = number & mask1;
                    bit1 >>= (p + i);
                    bit1 <<= (q + i);

                    uint mask2 = (uint)1 << (q + i);
                    uint bit2 = number & mask2;
                    bit2 >>= (q + i);
                    bit2 <<= (p + i);

                    if (bit1 == 0)
                    {
                        number &= (uint)~(1 << (q + i));
                    }
                    else
                    {
                        number |= bit1;
                    }

                    if (bit2 == 0)
                    {
                        number &= (uint)~(1 << (p + i));
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
