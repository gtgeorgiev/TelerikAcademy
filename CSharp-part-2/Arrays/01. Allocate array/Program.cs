﻿//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

using System;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }
        }
    }
}
