using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum += double.Parse(Console.ReadLine());    
            }
            
            Console.WriteLine("The sum is " + sum);
            
        }
    }
}
