//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

using System;
using System.Linq;


class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(FineLarger(numbers));
    }

    public static int FineLarger(int[] arr)
    {
        int number = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != 0)
            {
                if (i == arr.Length - 2)
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        number++;
                    }
                    break;
                }

                if (arr[i] > arr[i-1] && arr[i] > arr[i + 1])
                {
                    number++;
                }
                
            }
        }
        return number;
    }
}

