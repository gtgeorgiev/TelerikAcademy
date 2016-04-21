//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).

//The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//The output is like in the examples below.

using System;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double max = Double.MinValue;
            double min = Double.MaxValue;
            double number = 0;
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                number = double.Parse(Console.ReadLine());

                sum += number; //storage of sum

                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
        }
    }
}
