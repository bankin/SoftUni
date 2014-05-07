using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());;
            int binaryNumber = 0;

            for (int i = 0; decimalNumber != 0; i++)
            {
                int remain = decimalNumber % 2;
                binaryNumber = ((int)Math.Pow(10, i) * remain) + binaryNumber;


                decimalNumber /= 2;
            }

            Console.WriteLine(binaryNumber);
        }
    }
}
