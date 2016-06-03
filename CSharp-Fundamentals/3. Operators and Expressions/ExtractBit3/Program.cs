//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;


namespace ExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n= ");
            uint n = uint.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int nAndMask = (int) n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine("Bit at position 3 --> " + bit);
        }
    }
}
