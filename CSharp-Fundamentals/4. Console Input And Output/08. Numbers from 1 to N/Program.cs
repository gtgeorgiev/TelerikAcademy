﻿//Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.

using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }


    }
}
