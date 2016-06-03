//Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Linq;

class GetTheLargestNumber
{
    static void Main(string[] args)
    {
        string inputLineOfIntigers = Console.ReadLine();
        int[] stringToIntigers = inputLineOfIntigers.Split(' ').Select(int.Parse).ToArray();
        int biggestNumber = int.MinValue;
        int currentBigestNumber = int.MinValue;
        for (int i = 0; i < stringToIntigers.Length; i++)
        {
            if (i != 0)
            {
                currentBigestNumber = GetMax(stringToIntigers[i], stringToIntigers[i - 1]);
            }

            if (currentBigestNumber > biggestNumber)
            {
                biggestNumber = currentBigestNumber;
            }
        }

        Console.WriteLine(biggestNumber);
    }

    public static int GetMax(int number1, int number2)
    {
        int biggestNumber = number2;
        if (number1 > number2)
        {
            biggestNumber = number1;
        }

        return biggestNumber;
    }

}

