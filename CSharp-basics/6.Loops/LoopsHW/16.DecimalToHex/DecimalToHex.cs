using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string HexNumber = "";

            for (int i = 0; decimalNumber != 0; i++)
            {
                int remain = decimalNumber % 16;
                string charToAdd;
                switch (remain)
                {
                    case 10: charToAdd = "A"; break;
                    case 11: charToAdd = "B"; break;
                    case 12: charToAdd = "C"; break;
                    case 13: charToAdd = "D"; break;
                    case 14: charToAdd = "E"; break;
                    case 15: charToAdd = "F"; break;
                    default:
                        charToAdd = remain.ToString();
                        break;
                }
                HexNumber += charToAdd;
                decimalNumber /= 16;
            }

            char[] charArray = new char[HexNumber.Length];
            charArray = HexNumber.ToCharArray();
            Array.Reverse(charArray);
            HexNumber = new string(charArray);

            Console.WriteLine(HexNumber);
        }
    }
}
