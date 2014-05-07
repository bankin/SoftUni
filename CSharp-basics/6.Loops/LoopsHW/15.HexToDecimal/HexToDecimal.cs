using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            int decimalNumber = 0;
            string hexNumber = Console.ReadLine();

            for (int i = 0; i < hexNumber.Length; i++)
            {
                int multiplyer = 0;
                switch (hexNumber[i])
                {
                    case 'A':
                        multiplyer = 10;
                        break;
                    case 'B':
                        multiplyer = 11;
                        break;
                    case 'c':
                        multiplyer = 12;
                        break;
                    case 'D':
                        multiplyer = 13;
                        break;
                    case 'E':
                        multiplyer = 14;
                        break;
                    case 'F':
                        multiplyer = 15;
                        break;
                    default:
                        multiplyer = hexNumber[i] - '0';
                        break;
                }
                decimalNumber += multiplyer * (int)Math.Pow(16, hexNumber.Length - 1 - i);
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
