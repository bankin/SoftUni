using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input your weight: ");
                int weight = int.Parse(Console.ReadLine());
                Console.WriteLine("You weight on the moon will be "+weight * 0.17);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
