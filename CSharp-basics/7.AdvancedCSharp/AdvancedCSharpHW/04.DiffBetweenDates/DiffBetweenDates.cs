using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DiffBetweenDates
{
    class DiffBetweenDates
    {
        static void Main(string[] args)
        {
            string[] startDate = Console.ReadLine().Split('.');
            string[] endDate = Console.ReadLine().Split('.');

            DateTime start = new DateTime(int.Parse(startDate[2]), int.Parse(startDate[1]), int.Parse(startDate[0]));
            DateTime end = new DateTime(int.Parse(endDate[2]), int.Parse(endDate[1]), int.Parse(endDate[0]));

            TimeSpan diff = end.Subtract(start);
            Console.WriteLine(diff.Days);
        }
    }
}
