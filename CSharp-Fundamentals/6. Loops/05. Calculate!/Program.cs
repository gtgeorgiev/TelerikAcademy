//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

namespace _05.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1 + 1/x;

            for (int i = 2; i <= N; i++)
            {
                sum += Factorial(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", sum);
        }
        public static long Factorial(long n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
