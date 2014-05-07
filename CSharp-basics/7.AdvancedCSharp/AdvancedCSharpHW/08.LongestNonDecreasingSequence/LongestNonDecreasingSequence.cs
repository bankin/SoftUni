using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestNonDecreasingSequence
{
    class LongestNonDecreasingSequence
    {
        static bool isDecreasing(string sequence)
        {
            string[] nums = sequence.Trim().Split();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (int.Parse(nums[i]) > int.Parse(nums[i+1])){ return false; }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string longestSeq = "";
            int longesCount = 0;

            for (int i = 1; i < (int)Math.Pow(2,input.Length); i++)
			{
                string bitStr = Convert.ToString(i, 2).PadLeft(input.Length, '0');                
                string currentSeq = "";
                for (int j = 0; j < bitStr.Length; j++)
                {
                    if (bitStr[j].Equals('1'))
                    {
                        currentSeq += input[j] + " ";
                    }
                }
                //Console.WriteLine(currentSeq);
                if (isDecreasing(currentSeq))
                {
                    //Console.WriteLine(currentSeq);
                    //Console.WriteLine(" is decreasing");
                    if (currentSeq.Split().Length > longesCount)
                    {
                        longesCount = currentSeq.Split().Length;
                        longestSeq = currentSeq;
                    }
                }
			}

            Console.WriteLine(longestSeq);
        }
    }
}
