//Write a program that reads the coefficients a, b and c of a quadratic equation a(x^2) + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            double x1 = (-b - (Math.Sqrt(d))) / (2 * a);
            double x2 = (-b + (Math.Sqrt(d))) / (2 * a);
            Console.WriteLine("{0:F2}", Math.Min(x1, x2));
            Console.WriteLine("{0:F2}", Math.Max(x1, x2));
        }
    }
}
