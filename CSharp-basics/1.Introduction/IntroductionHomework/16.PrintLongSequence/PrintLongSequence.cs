using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            Console.Write(2); 
            for (int i = 3; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("," + i);
                }
                else
                {
                    Console.Write("," + (-i));
                }
            }
        }
    }
}
