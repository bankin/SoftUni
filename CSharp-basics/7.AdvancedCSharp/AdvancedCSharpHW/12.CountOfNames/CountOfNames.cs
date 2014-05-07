using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Array.Sort(names);
            int currCount = 1;
            for (int i = 0; i < names.Length - 1; i++)
            {
                
                if (names[i] == names[i + 1])
                {
                    currCount++;
                }
                else
                {
                    Console.WriteLine(names[i] + " -> " + currCount);
                    currCount = 1;
                }
            }
            if (names[names.Length-1] == names[names.Length-2])
            {
                Console.WriteLine(names[names.Length-1] + " -> " + currCount);             
            }
            else
            {
                Console.WriteLine(names[names.Length - 1] + " -> " + 1);
            }
        }
    }
}
