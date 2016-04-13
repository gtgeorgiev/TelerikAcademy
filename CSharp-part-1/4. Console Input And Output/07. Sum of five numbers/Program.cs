//Write a program that reads 5 integer numbers from the console and prints their sum.

using System;

namespace _07.Sum_of_5_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                sum += input[i];
            }

            Console.WriteLine(sum);
        }
    }
}
