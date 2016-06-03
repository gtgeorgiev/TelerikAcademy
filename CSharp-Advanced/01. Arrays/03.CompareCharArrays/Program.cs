//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace _03.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input two chars as a string
            string firstInputString = Console.ReadLine();
            string secondInputString = Console.ReadLine();
            int lenght;
            char ch = '<';

            if (firstInputString.Length > secondInputString.Length)
            {
                lenght = secondInputString.Length;
            }
            else
            {
                lenght = firstInputString.Length;
            }

            if (firstInputString == secondInputString)
            {
                Console.WriteLine("=");
            }
            else
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (firstInputString[i] <= secondInputString[i])
                    {
                        continue;
                    }
                    else
                    {
                        ch = '>';
                        break;
                    }
                }

                //Output
                Console.WriteLine("{0}", ch);
            }
        }
    }
}
