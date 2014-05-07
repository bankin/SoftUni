using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractThirdBit
{
    class ExtractThirdBit
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());

                number >>= 3;
                
                int res = number & 1;
                Console.WriteLine("The third bit is "+res);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
