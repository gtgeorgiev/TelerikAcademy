//Write a program that reads from the console the radius r of a circle and prints its perimeter and area, 
//rounded and formatted with 2 digits after the decimal point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiusOfCircle = double.Parse(Console.ReadLine());

            double perimeterOfCircle = 2 * Math.PI * radiusOfCircle;
            double areaOfCircle = Math.PI * radiusOfCircle * radiusOfCircle;

            Console.WriteLine("{0:F2} {1:F2}", perimeterOfCircle, areaOfCircle);
        }
    }
}
