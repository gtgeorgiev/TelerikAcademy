//Write a program that reads a string, reverses it and prints the result on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string reversed = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine(reversed);
    }
}
