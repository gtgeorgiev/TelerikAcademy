//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

using System;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInputNumber = double.Parse(Console.ReadLine());
            double secondInputNumber = double.Parse(Console.ReadLine());
            double thirdInputNumber = double.Parse(Console.ReadLine());
            double fourthInputNumber = double.Parse(Console.ReadLine());
            double fivethInputNumber = double.Parse(Console.ReadLine());

            if (firstInputNumber >= secondInputNumber && firstInputNumber >= thirdInputNumber && firstInputNumber >= fourthInputNumber
                && firstInputNumber >= fivethInputNumber)
            {
                Console.WriteLine(firstInputNumber);
            }
            else if (secondInputNumber >= firstInputNumber && secondInputNumber >= thirdInputNumber && 
                secondInputNumber >= fourthInputNumber && secondInputNumber >= fivethInputNumber)
            {
                Console.WriteLine(secondInputNumber);
            }
            else if (thirdInputNumber >= firstInputNumber && thirdInputNumber >= secondInputNumber && 
                thirdInputNumber >= fourthInputNumber && thirdInputNumber >= fivethInputNumber)
            {
                Console.WriteLine(thirdInputNumber);
            }
            else if (fourthInputNumber >= firstInputNumber && fourthInputNumber >= secondInputNumber &&
                fourthInputNumber >= thirdInputNumber && fourthInputNumber >= fivethInputNumber)
            {
                Console.WriteLine(fourthInputNumber);
            }
            else
            {
                Console.WriteLine(fivethInputNumber);
            }
        }
    }
}
