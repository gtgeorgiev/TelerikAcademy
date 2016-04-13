//Write a program that reads the coefficients a, b and c of a quadratic equation a(x^2) + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double biggerRoot;
            double smallerRoot;

            if (firstRoot > secondRoot)
            {
                biggerRoot = firstRoot;
                smallerRoot = secondRoot;
            }
            else 
            {
                biggerRoot = secondRoot;
                smallerRoot = firstRoot;
            }

            if (discriminant > 0)
            {
                Console.WriteLine("{0:F2} {1:F2}", smallerRoot, biggerRoot);
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("{0:F2}", ((-b) /(double) (2 * a)));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
