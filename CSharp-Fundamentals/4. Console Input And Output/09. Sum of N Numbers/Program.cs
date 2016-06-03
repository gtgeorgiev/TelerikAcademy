//Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] input = new double[N];
        double sum = 0;

        for (int i = 0; i < N; i++)
        {
            input[i] = double.Parse(Console.ReadLine());
            sum += input[i];
        }
        Console.WriteLine(sum);
    }
}

