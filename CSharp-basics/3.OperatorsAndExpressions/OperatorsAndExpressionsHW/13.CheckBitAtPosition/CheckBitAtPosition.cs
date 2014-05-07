using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Please input the position: ");
                int position = int.Parse(Console.ReadLine());

                number >>= position;
                int res = number & 1;

                Console.WriteLine(res == 1 ? "True" : "False");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
