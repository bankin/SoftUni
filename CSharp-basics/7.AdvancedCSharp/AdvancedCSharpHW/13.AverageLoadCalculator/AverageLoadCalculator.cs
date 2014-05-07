using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AverageLoadCalculator
{
    class AverageLoadCalculator
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> upTime = new Dictionary<string, double>();
            Dictionary<string, int> dataCount = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Enter new data if present : ");
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 2)
                    {
                        if (upTime.ContainsKey(input[i]))
                        {
                            upTime[input[i]] += double.Parse(input[i + 1]);
                            dataCount[input[i]]++;
                        }
                        else
                        {
                            upTime.Add(input[i], double.Parse(input[i + 1]));
                            dataCount.Add(input[i], 1);
                        }
                    }
                }

                Console.Clear();
                Console.WriteLine("Up-to-date info ");
                foreach (var item in upTime)
                {
                    Console.WriteLine(item.Key + " -> " + item.Value / dataCount[item.Key]);
                }
            }
        }
    }
}
