//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubStringInText
{
    public static int FindPatternInText(string pattern, string text)
    {
        var patternToLower = pattern.ToLower();
        var textToLower = text.ToLower();
        var counter = 0;
        int index = textToLower.IndexOf(patternToLower);

        while (index != -1)
        {
            counter++;
            index = textToLower.IndexOf(patternToLower, index + 1);
        }

        return counter;
    }

    static void Main()
    {
        var pattern = Console.ReadLine();
        var text = Console.ReadLine();

        Console.WriteLine(FindPatternInText(pattern, text));
    }
}
