using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRoller
{
    class BitRoller
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int freezed = int.Parse(Console.ReadLine());
            int rolls = int.Parse(Console.ReadLine());

            char[] bitNum = Convert.ToString(number, 2).PadLeft(19, '0').ToCharArray();
            //Console.WriteLine(bitNum);

            for (int i = 0; i < rolls; i++)
            {
                char firstBit;
                if (freezed == 0)
                {
                    firstBit = bitNum[bitNum.Length - 2];
                }
                else
                {
                    firstBit = bitNum[bitNum.Length - 1];
                }
                
                for (int j = bitNum.Length - 1; j  > 0; j--)
                {
                    if (j == bitNum.Length - freezed)
                    {
                        if (j == 1)
                        {
                            bitNum[j] = firstBit;
                        }
                        else
                        {
                            bitNum[j] = bitNum[j - 2];
                        }
                    }
                    else if (j == bitNum.Length - freezed - 1) {}
                    else
                    {
                        bitNum[j] = bitNum[j - 1];
                    }
                }
                if (freezed != 18)
                {
                    bitNum[0] = firstBit;   
                }
            }

            int result = Convert.ToInt32(new String(bitNum), 2);
            Console.WriteLine(result);
        }
    }
}
