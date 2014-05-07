using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountWordInText
{
    class CountWordInText
    {
        static void Main(string[] args)
        {
            string needle = Console.ReadLine().ToLower();
            string[] haystack = Console.ReadLine().Split(' ',',','.','"','/','\\',';','!','?','\'','@','(',')',':');
            int totalCount = 0;
            for (int i = 0; i < haystack.Length; i++)
            {                
                if (haystack[i].ToLower().Equals(needle)) { totalCount++; }
            }

            Console.WriteLine(totalCount);
        }
    }
}
