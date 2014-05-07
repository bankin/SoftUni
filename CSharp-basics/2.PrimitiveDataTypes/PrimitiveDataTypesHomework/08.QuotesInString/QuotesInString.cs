using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.QuotesInString
{
    class QuotesInString
    {
        static void Main(string[] args)
        {
            string msg1 = @"The ""use"" of quotations causes difficulties.";
            string msg2 = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
        }
    }
}
