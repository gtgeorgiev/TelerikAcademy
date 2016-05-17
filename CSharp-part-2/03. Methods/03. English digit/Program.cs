//Write a method that returns the last digit of given integer as an English word. Write a program that reads a number and prints the result of the method.

using System;
using System.Linq;


class EnglishDigit
{
    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int lastDigitInInputNumber = inputNumber % 10;

        Console.WriteLine(ConvertNumberToWord(lastDigitInInputNumber));
    }

    public static string ConvertNumberToWord(int number)
    {
        string word = "";
        switch (number)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
        }

        return word;
    }
}

