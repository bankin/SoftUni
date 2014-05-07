using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PerimeterAndArea
{
    class PerimeterAndArea
    {
        static void Main(string[] args)
        {
            int pointsCount = int.Parse(Console.ReadLine());
            double[,] points = new double[pointsCount, 2];

            for (int i = 0; i < pointsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                points[i, 0] = double.Parse(input[0]);
                points[i, 1] = double.Parse(input[1]);
            }
            double area = 0;
            double perimeter = 0;
            for (int i = 0; i < pointsCount; i++)
            {
                if (i != pointsCount - 1)
                {
                    area += points[i, 0] * points[i + 1, 1] - points[i, 1] * points[i + 1, 0];
                    double ySub = Math.Abs(points[i, 1] - points[i + 1, 1]);
                    double xSub = Math.Abs(points[i, 0] - points[i + 1, 0]);
                    perimeter += Math.Sqrt(ySub*ySub + xSub*xSub);
                }
                else
                {
                    double ySub = Math.Abs(points[i, 1] - points[0, 1]);
                    double xSub = Math.Abs(points[i, 0] - points[0, 0]);
                    perimeter += Math.Sqrt(ySub * ySub + xSub * xSub);
                    area += points[i, 0] * points[0, 1] - points[i, 1] * points[0, 0];
                }
            }

            Console.WriteLine("Area: " + Math.Abs(area/2));
            Console.WriteLine("Perimeter: {0:0.00}",perimeter);
        }
    }
}
