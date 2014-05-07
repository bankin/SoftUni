using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool negative = false;

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (a > 0) { negative = false; }
            else { negative = true; }

            if (b < 0) { negative = !negative; }
            if (c < 0) { negative = !negative; }

            Console.WriteLine(negative ? "-" : "+");

            
        }
    }
}
