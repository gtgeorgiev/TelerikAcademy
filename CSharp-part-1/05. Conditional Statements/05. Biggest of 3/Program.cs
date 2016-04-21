//Write a program that finds the biggest of three numbers that are read from the console.

using System;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInputNumber = double.Parse(Console.ReadLine());
            double secondInputNumber = double.Parse(Console.ReadLine());
            double thirdInputNumber = double.Parse(Console.ReadLine());

            if (firstInputNumber >= secondInputNumber && firstInputNumber >= thirdInputNumber)
            {
                Console.WriteLine(firstInputNumber);
            }
            else if (secondInputNumber >= firstInputNumber && secondInputNumber >= thirdInputNumber)
            {
                Console.WriteLine(secondInputNumber);
            }
            else
            {
                Console.WriteLine(thirdInputNumber);
            }
        }
    }
}
