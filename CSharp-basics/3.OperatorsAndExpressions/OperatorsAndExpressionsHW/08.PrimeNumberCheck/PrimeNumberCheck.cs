using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input your number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0) { Console.WriteLine("No, it is not prime"); return; }
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("No, it is not prime");
                        return;
                    }
                }
                Console.WriteLine("Yes, it is prime");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
