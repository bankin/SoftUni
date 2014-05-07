using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input rectangle's height: ");
                int height = int.Parse(Console.ReadLine());
                Console.Write("Please input rectangle's width: ");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("The rectangle's area is "+height*width);
                Console.WriteLine("The rectangle's perimeter is "+(2*width+2*height));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
