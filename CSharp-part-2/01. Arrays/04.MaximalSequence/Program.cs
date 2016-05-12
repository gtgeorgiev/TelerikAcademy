//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

using System;

namespace _04.MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Console.WriteLine(FindLengthOfMaxSequence(arr));

        }

        static int FindLengthOfMaxSequence(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 1;

            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
                if (index != 0)
                {
                    if (arr[index] == arr[index - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
            }
            return maxCount;
        }
    }
}
