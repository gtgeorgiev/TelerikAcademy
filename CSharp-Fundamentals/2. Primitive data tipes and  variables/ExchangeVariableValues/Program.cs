//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange 
//their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            // before excharge
            int a = 5;
            int b = 10;
            Console.WriteLine("before exchange: a= " + a);
            Console.WriteLine("                 b= " + b);

            //after excharch
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after exchange: a= " + a);
            Console.WriteLine("                b= " + b);

        }
    }
}
