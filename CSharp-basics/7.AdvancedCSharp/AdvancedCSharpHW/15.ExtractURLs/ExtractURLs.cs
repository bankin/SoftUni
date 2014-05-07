using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ExtractURLs
{
    class ExtractURLs
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            List<string> sites = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].StartsWith("http://")) { if (!sites.Contains(text[i])) { sites.Add(text[i].Trim(' ','.')); } }
                if (text[i].StartsWith("www.")) { if (!sites.Contains(text[i])) { sites.Add(text[i].Trim(' ','.')); } }
            }

            for (int i = 0; i < sites.Count; i++)
            {
                Console.WriteLine(sites[i]);
            }
        }
    }
}
