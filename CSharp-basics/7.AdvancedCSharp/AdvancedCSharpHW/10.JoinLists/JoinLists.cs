using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string[] list1 = Console.ReadLine().Split();
            string[] list2 = Console.ReadLine().Split();
            List<int> joinLists = new List<int>();

            for (int i = 0; i < list1.Length; i++)
            {
                joinLists.Add(int.Parse(list1[i]));
            }
            for (int i = 0; i < list2.Length; i++)
            {
                joinLists.Add(int.Parse(list2[i]));
            }
            
            joinLists.Sort();            

            for (int i = 0; i < joinLists.Count() - 1; i++)
            {
                if (joinLists[i] == joinLists[i+1])
                {
                    joinLists.RemoveAt(i + 1);
                    i--;
                }
                else
                {
                    Console.Write(joinLists[i] + ", ");
                }
            }
            if (joinLists[joinLists.Count - 2] != joinLists[joinLists.Count - 1]) { Console.WriteLine(joinLists[joinLists.Count-1]); }
        }
    }
}
