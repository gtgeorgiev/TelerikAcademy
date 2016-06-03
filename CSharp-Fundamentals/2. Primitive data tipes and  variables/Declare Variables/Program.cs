/* Problem 1. Declare Variables
 * Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
 * short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            byte a = 97;
            Console.WriteLine(a + " --> byte");

            sbyte b = -115;
            Console.WriteLine(b + " --> sbyte");

            ushort c = 52130;
            Console.WriteLine(c + " --> ushort");

            short d = -10000;
            Console.WriteLine(d + " --> short");

            int e = 4825932;
            Console.WriteLine(e + " --> int");
        }
    }
}