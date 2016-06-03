//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some four-digit number: ");
            int fourDigitNumber = int.Parse(Console.ReadLine());
            // Is this four-digit number?
            if ((fourDigitNumber / 1000 == 0) || (fourDigitNumber / 1000 > 9))
            {
                Console.WriteLine("This is not four-digit number!!!");
            }
            else {
                int firstDigit = fourDigitNumber / 1000;
                int secondDigit = (fourDigitNumber % 1000) / 100;
                int thirdDigit = ((fourDigitNumber % 1000) % 100) / 10;
                int fourthDigit = (((fourDigitNumber % 1000) % 100) % 10);

                // Sum of digits
                Console.WriteLine("Sum of the digits: {0} + {1} + {2} + {3} = {4}",
                                    firstDigit, secondDigit, thirdDigit, fourthDigit,
                                    (firstDigit + secondDigit + thirdDigit + fourthDigit));

                // Number in reversed order: dcba
                Console.WriteLine("The number in reversed order(dcba): " +
                                    fourthDigit + thirdDigit + secondDigit + firstDigit);

                // Last digit in the first position: dabc
                Console.WriteLine("Last digit in the first position (dabc): " +
                                    fourthDigit + firstDigit + secondDigit + thirdDigit);

                // Exchanges the second and the third digits: acbd
                Console.WriteLine("Exchanges the second and the third digits (acbd): " +
                    firstDigit + thirdDigit + secondDigit + fourthDigit);
            }
        }
    }
}
