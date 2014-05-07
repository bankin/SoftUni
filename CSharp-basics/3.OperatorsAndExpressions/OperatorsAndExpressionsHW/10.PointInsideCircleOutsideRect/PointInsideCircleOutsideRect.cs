using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideCircleOutsideRect
{
    class PointInsideCircleOutsideRect
    {
        static bool pointInCircle(int centerX, int centerY, double radius, double pointX, double pointY)
        {
            double dist = Math.Sqrt(Math.Pow(Math.Abs(pointX - centerX), 2) + Math.Pow(Math.Abs(pointY - centerY), 2));

            return dist < radius;
        }

        static bool pointInRect(int top, int left, int height, int width, double pointX, double pointY)
        {
            if (pointX > (left + width)) { return false; }
            if (pointX < left) { return false; }
            if (pointY > top) { return false; }
            if (pointY < (top - height)) { return false; }

            return true;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please input point's x coord: ");
                double pointX = double.Parse(Console.ReadLine());
                Console.Write("Please input point's y coord: ");
                double pointY = double.Parse(Console.ReadLine());

                Console.WriteLine(pointInCircle(1, 1, 1.5, pointX, pointY) && !pointInRect(1, -1, 2, 6, pointX, pointY) ? "Yes it is in the circle and out of rect" : "No it is not in the circle and out of rect");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
