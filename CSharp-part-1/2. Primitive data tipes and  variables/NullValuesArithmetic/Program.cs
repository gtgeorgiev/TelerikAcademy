//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullValueInt = null;
            double? nullValueDouble = null;
            Console.WriteLine("Integer with value Null: " + nullValueInt);
            Console.WriteLine("Integer with value Double: " + nullValueInt);

            //asign some valuels to nullable variables
            nullValueInt = 10;
            nullValueDouble = 10.9;
            Console.WriteLine("Nullable integer with value 10: " + nullValueInt);
            Console.WriteLine("Nullable doble with value 10.9: " + nullValueDouble);

        }
    }
}
