﻿//Write a program that reads two double values from the console A and B, stores them in variables and exchanges 
//their values if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, 
//separated by a space.

using System;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("{0} {1}", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}
