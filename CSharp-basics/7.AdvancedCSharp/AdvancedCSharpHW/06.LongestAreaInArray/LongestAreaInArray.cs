using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxCount = 0;
            int currCount = 1;
            string current ="";
            string prev = Console.ReadLine();
            string longestArea = prev;
            for (int i = 1; i < n; i++)
            {
                current = Console.ReadLine();
                if (current == prev)
                {
                    currCount++;
                }
                else
                {
                    if (currCount > maxCount)
                    {
                        longestArea = prev;
                        maxCount = currCount;
                    }
                    prev = current;
                    currCount = 1;
                }
            }

            if (currCount > maxCount)
            {
                longestArea = prev;
            }            

            Console.WriteLine(longestArea);
        }
    }
}
