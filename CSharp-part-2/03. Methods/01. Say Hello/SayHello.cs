﻿//Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

using System;

class SayHello
{
    static void Main(string[] args)
    {
        string inputName = Console.ReadLine();
        PrintName(inputName);

    }

    public static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}

