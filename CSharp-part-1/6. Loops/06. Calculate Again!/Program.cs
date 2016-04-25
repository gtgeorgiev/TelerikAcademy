//Write a program that calculates N! / K! for given N and K.

//Use only one loop.

using System;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numberN = BigInteger.Parse(Console.ReadLine());
            BigInteger numberK = BigInteger.Parse(Console.ReadLine());

            BigInteger division = 1;

            for (BigInteger i = numberK + 1; i <= numberN; i++)
            {
                division *= i;
            }

            Console.WriteLine(division);
        }
    }
}
