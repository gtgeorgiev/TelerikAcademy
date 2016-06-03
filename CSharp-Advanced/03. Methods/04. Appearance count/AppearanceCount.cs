//Write a method that counts how many times given number appears in a given array. Write a test program to check if the method is working correctly.

using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        string inputArray = Console.ReadLine();
        int[] stringToIntigers = inputArray.Split(' ').Select(int.Parse).ToArray();
        int nemberX = int.Parse(Console.ReadLine());

        Console.WriteLine(Check(sizeOfArray, stringToIntigers, nemberX));
    }

    public static int Check(int sizeOfArr, int[] arr, int numberX)
    {
        int repeat = 0;
        for (int i = 0; i < sizeOfArr; i++)
        {
            if (arr[i] == numberX)
            {
                repeat++;
            }
        }
        return repeat;
    }
}

