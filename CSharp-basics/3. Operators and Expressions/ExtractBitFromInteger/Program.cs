//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
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
            Console.WriteLine(bit);
        }
    }
}
