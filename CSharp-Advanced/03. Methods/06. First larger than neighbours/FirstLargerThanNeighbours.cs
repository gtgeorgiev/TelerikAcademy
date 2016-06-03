//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

using System;
using System.Linq;


class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(FindIndexOfFirstLarger(numbers));
    }

    public static int FindIndexOfFirstLarger(int[] arr)
    {
        int index = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != 0)
            {
                if (i == arr.Length - 2)
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
                if (arr[i] > arr[i-1] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
            }
        }

        return index;
    }


    
}

