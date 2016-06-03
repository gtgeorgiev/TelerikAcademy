//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some intiger:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? "Number is even!" : "Number is odd!");
        }
    }
}
