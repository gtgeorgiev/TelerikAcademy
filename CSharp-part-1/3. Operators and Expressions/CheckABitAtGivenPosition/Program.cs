//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter p= ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;

            Boolean value = (bit == 1);
            Console.WriteLine(value);        
        }
    }
}
