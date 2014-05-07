using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static bool pointInCircle(int centerX, int centerY, int radius, double pointX, double pointY)
        {
            double dist = Math.Sqrt(Math.Pow(Math.Abs(pointX - centerX), 2) + Math.Pow(Math.Abs(pointY - centerY), 2));

            return dist < radius;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input point's x coord: ");
                double pointX = double.Parse(Console.ReadLine());
                Console.Write("Please input point's y coord: ");
                double pointY = double.Parse(Console.ReadLine());
                Console.WriteLine(pointInCircle(0,0,2,pointX,pointY) ? "Yes it is in the circle" : "No it is not in the circle");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
