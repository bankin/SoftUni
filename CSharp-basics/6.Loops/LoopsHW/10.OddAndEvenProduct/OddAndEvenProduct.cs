using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split();
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= int.Parse(numbers[i].ToString());
                }
                else
                {
                    evenProduct *= int.Parse(numbers[i].ToString());
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = "+oddProduct);
                Console.WriteLine("even_product = "+evenProduct);
            }
        }
    }
}
