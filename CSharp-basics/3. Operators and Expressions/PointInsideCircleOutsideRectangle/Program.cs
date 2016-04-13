//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            bool inCircleOutRectangle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5
                                        && ((x < -1 || x > 5) && (y < -1 || y > 1));

            Console.WriteLine("Inside K & outside of R ---> " + inCircleOutRectangle);
        }
    }
}
