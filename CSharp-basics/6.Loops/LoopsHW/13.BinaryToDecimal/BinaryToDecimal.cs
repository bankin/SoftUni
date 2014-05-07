using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int decimalNumber = 0;
            int binaryNumber = int.Parse(Console.ReadLine());

            for (int i = 0; binaryNumber != 0; i++)
            {
                decimalNumber += (int)Math.Pow(2, i) * (binaryNumber % 10);

                binaryNumber /= 10;
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
