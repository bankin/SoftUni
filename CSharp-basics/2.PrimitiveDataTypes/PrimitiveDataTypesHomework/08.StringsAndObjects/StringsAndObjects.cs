using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "world";
            object msg = hello + world;
            string helloWorld = (string)msg;
            Console.WriteLine(helloWorld);
        }
    }
}
