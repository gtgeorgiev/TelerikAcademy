//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y= ");
            double y = double.Parse(Console.ReadLine());
            // Check in first quadrant
            if ((x >= 0 && x <= 2) && (y >= 0 && y <= 2)) 
            {
                Console.WriteLine("The point is inside the cyrcle!");
            }
            // Check in second quadrant
            else if ((x >= -2 && x <= 0) && (y >= 0 && y <= 2))
            {
                Console.WriteLine("The point is inside the cyrcle!");
            }
            // Check in third quadrant
            else if ((x >= -2 && x <= 0) && (y >= -2 && y <= 0))
            {
                Console.WriteLine("The point is inside the cyrcle!");
            }
            // Check in fourth quadrant
            else if ((x >= 0 && x <= 2) && (y >= -2 && y <= 0))
            {
                Console.WriteLine("The point is inside the cyrcle!");
            }

            else
            {
                Console.WriteLine("The point is not inside the cyrcle!");
            }


        }
    }
}
