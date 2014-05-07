using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordInText
{
    class LongestWordInText
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ','.');
            int longest = 0;
            string longestWord = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > longest)
                {
                    longestWord = text[i];
                    longest = text[i].Length;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
