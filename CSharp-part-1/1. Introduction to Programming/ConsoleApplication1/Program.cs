//Problem 9. Print a Sequence

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteSequence
{
    class WriteSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10;)
            {
            Console.WriteLine(i++);
            Console.WriteLine(-i++);
            }
        }
    }
}
