//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;

namespace _02.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] firstArray = new int[N];
            int[] secondArray = new int[N];
            string isEqual = "Equal";

            //Read elements of firstArray
            for (int i = 0; i < N; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            //Read elements of secondArray
            for (int j = 0; j < N; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }

            //Compare elements of both arrays
            for (int z = 0; z < N; z++)
            {
                if (firstArray[z] == secondArray[z])
                {
                    continue;
                }
                else
                {
                    isEqual = "Not equal";
                    break;
                }
            }

            //Output
            Console.WriteLine("{0}", isEqual);
        }
    }
}
