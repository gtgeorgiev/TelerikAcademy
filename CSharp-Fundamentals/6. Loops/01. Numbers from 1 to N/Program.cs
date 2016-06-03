//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, 
//on a single line, separated by a whitespace.

using System;

namespace _01.Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
