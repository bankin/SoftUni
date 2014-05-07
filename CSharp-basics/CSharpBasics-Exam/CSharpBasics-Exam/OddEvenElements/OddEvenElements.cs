using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputNums = input.Split();
            decimal oddSum = 0, oddMin = 0, oddMax = 0;
            decimal evenSum = 0, evenMin = 0, evenMax = 0;
            bool odd = false, even = false;

            for (int i = 0; i < inputNums.Length; i++)
            {
                decimal current;
                bool isNum = decimal.TryParse(inputNums[i], out current);
                if (!isNum) { }
                else
                {
                    current = decimal.Parse(inputNums[i]);

                    if (i % 2 != 0)
                    {
                        evenSum += current;
                        if (!even)
                        {
                            even = true;
                            evenMin = current;
                            evenMax = current;
                        }
                        else
                        {
                            if (current > evenMax)
                            {
                                evenMax = current;
                            }
                            if (current < evenMin)
                            {
                                evenMin = current;
                            }
                        }
                    }
                    else
                    {
                        oddSum += current;
                        if (!odd)
                        {
                            odd = true;
                            oddMin = current;
                            oddMax = current;
                        }
                        else
                        {
                            if (current > oddMax)
                            {
                                oddMax = current;
                            }
                            if (current < oddMin)
                            {
                                oddMin = current;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (odd ? ((double)oddSum).ToString() : "No"),
                (odd ? ((double)oddMin).ToString() : "No"),
                (odd ? ((double)oddMax).ToString() : "No"),
                (even ? ((double)evenSum).ToString() : "No"),
                (even ? ((double)evenMin).ToString() : "No"),
                (even ? ((double)evenMax).ToString() : "No"));
        }
    }
}
