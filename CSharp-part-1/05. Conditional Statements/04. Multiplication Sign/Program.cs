//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInputNumber = double.Parse(Console.ReadLine());
            double secondInputNumber = double.Parse(Console.ReadLine());
            double thirdInputNumber = double.Parse(Console.ReadLine());

            double productOfTreeNumbers = firstInputNumber * secondInputNumber * thirdInputNumber;

            if (productOfTreeNumbers > 0)
            {
                Console.WriteLine("+");
            }
            else if (productOfTreeNumbers < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
