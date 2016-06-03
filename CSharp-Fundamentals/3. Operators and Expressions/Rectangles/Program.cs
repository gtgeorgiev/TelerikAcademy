//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            // width of rectangle
            Console.Write("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            //height of rectangle
            Console.Write("Enter height of rectangle: ");
            double height = double.Parse(Console.ReadLine());

            // Rectangle's perimeter
            Console.WriteLine("Rectangle's perimeter is: " + (2 * (width + height)));

            // Rectangle's area
            Console.WriteLine("Rectangle's area: " + (width * height));
        }
    }
}
