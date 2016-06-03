//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some value: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Divided by 7 and 5? " + (num % 5 == 0 && num % 7 == 0 ? "True" : "False"));

        }
    }
}
