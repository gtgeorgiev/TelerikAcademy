//Write a program that gets two numbers from the console and prints the greater of them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Numbers_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double greater;

            if (firstNumber > secondNumber)
            {
                greater = firstNumber;
            }
            else if (firstNumber < secondNumber)
            {
                greater = secondNumber;
            }
            else
            {
                greater = firstNumber;
            }

            Console.WriteLine(greater);

        }
    }
}
