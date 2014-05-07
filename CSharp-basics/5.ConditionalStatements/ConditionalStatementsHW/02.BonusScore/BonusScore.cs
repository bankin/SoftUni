using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            int finalScore = 0;
            if (score >= 1 && score <= 3)
            {
                finalScore = score * 10;
            }
            else if (score >= 4 && score <= 6)
            {
                finalScore = score * 100;
            }
            else if (score >= 7 && score <= 9)
            {
                finalScore = score * 1000;
            }
            else
            {
                Console.WriteLine("invalid score");
                return;
            }

            Console.WriteLine(finalScore);
        }
    }
}
