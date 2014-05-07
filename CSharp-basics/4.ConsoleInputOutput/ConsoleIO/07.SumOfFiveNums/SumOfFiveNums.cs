using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfFiveNums
{
    class SumOfFiveNums
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }

            Console.WriteLine("Sum = "+ sum);
        }
    }
}
