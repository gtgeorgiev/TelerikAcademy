//Problem 8. Isosceles Triangle
//Note: The © symbol may be displayed incorrectly at the console so you may 
//need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, 
//regardless of how much effort you put to fix it.﻿

using System;

class CopyrightTriangle
{
    static void Main(string[] args)
    {
        char a = '\u00a9';
        Console.WriteLine("    " + a);
        Console.WriteLine("");
        Console.WriteLine("   " + a + " " + a);
        Console.WriteLine();
        Console.WriteLine("  " + a + "   " + a);
        Console.WriteLine();
        Console.WriteLine(" " + a + " " + a + " " + a + " " + a);  
    }
}