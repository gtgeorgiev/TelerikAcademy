//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            // Enter some value
            Console.Write("Enter some value: ");
            double num = double.Parse(Console.ReadLine());

            // Devide to 100
            double  num2 = (num % 100);

            // Devide to 10
            double num3 = (num2 % 10);

            // The result
            Console.WriteLine("Third Digit is 7? " + (num3 == 7 ? "True" : "False"));
        }
    }
}
