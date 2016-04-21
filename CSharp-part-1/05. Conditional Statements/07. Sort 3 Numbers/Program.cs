//Write a program that enters 3 real numbers and prints them sorted in descending order.

//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.

using System;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInputNumber = int.Parse(Console.ReadLine());
            int secondInputNumber = int.Parse(Console.ReadLine());
            int thirdInputNumber = int.Parse(Console.ReadLine());

            if (firstInputNumber >= secondInputNumber && firstInputNumber >= thirdInputNumber)
            {
                if (secondInputNumber >= thirdInputNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstInputNumber, secondInputNumber, thirdInputNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstInputNumber, thirdInputNumber, secondInputNumber);
                }
            }
            else if (secondInputNumber >= firstInputNumber && secondInputNumber >= thirdInputNumber)
            {
                if (firstInputNumber >= thirdInputNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondInputNumber, firstInputNumber, thirdInputNumber );
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondInputNumber, thirdInputNumber, firstInputNumber);
                }
            }
            else
            {
                if (firstInputNumber >= secondInputNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdInputNumber, firstInputNumber, secondInputNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdInputNumber, secondInputNumber, firstInputNumber);
                }
            }
        }
    }
}
