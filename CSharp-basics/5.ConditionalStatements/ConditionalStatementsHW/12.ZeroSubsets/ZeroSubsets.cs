using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ZeroSubsets
{
    class ZeroSubsets
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < 32; i++)
            {
                string num = Convert.ToString(i, 2).PadLeft(5, '0');
                int sum = 0;
                string sumNums = "";
                for (int j = 0; i < 5; i++)
                {
                    if (num[j] == '1') { sum += numbers[j]; sumNums += numbers[j]+"+";}
                }

                if (sum == 0)
                {
                    //sumNums = sumNums.Remove(sumNums.Length - 2,1);
                    sumNums += " = 0";
                    Console.WriteLine(sumNums);
                }
            }
        }
    }
}
