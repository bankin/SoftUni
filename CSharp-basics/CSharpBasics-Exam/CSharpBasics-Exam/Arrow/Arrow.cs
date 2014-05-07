using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            string firstRow = new String('.', width / 2);
            firstRow += new String('#', width);
            firstRow += new String('.', width / 2);

            Console.WriteLine(firstRow);
            for (int i = 0; i < width-2; i++)
            {
                Console.Write(new String('.', width/2));
                Console.Write('#');
                Console.Write(new String('.', width-2));
                Console.Write('#');
                Console.WriteLine(new String('.', width / 2));
            }
            Console.Write(new String('#', width/2 + 1));
            Console.Write(new String('.',width-2));
            Console.WriteLine(new String('#', width/2 + 1));
            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(new String('.', i + 1));
                Console.Write('#');
                Console.Write(new String('.', width*2 - (1 + 2 + 2 + 2*i)));
                Console.Write('#');
                Console.WriteLine(new String('.', i + 1));                
            }

            Console.Write(new String('.',width-1));
            Console.Write('#');
            Console.Write(new String('.', width - 1));
        }
    }
}
