//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double sumOfTreeNumbers = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("{0}", sumOfTreeNumbers);
        }
    }
}
