using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> toRemove = Console.ReadLine().Split().ToList();

            for (int i = 0; i < toRemove.Count; i++)
            {
                for (int j = 0; j < names.Count; j++)
                {
                    if (names[j] == toRemove[i])
                    {
                        names.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.Write(names[i] + ", ");
            }
        }
    }
}
