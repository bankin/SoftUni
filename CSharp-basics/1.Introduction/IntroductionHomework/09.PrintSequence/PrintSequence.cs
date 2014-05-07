using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            Console.Write(2);
            for (int i = 3; i < 12; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(","+i);
                }
                else
                {
                    Console.Write(","+(-i));
                }
            }
        }
    }
}
