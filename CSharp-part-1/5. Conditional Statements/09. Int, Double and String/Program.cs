//Write a program that, depending on the first line of the input, reads an int, double or string variable.

//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "integer":
                    {
                        int integerNumber = int.Parse(Console.ReadLine());
                        integerNumber++;
                        Console.WriteLine(integerNumber);
                    }
                    break;

                case "real":
                    {
                        double doubleNumber = double.Parse(Console.ReadLine());
                        doubleNumber++;
                        Console.WriteLine(doubleNumber);
                    }
                    break;

                case "text":
                    {
                        string strInput = Console.ReadLine();
                        strInput = strInput + "*";
                        Console.WriteLine(strInput);
                    }
                    break;
            }
        }
    }
}
