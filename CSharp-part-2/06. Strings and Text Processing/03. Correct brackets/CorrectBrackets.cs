using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class CorrectBrackets
{
    public static string IsCorrectBrackets(string input)
    {
        var isCorrect = "Correct";
        var countOfOpenBrackets = 0;
        var countOfCloseBracets = 0;


        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                countOfOpenBrackets++;
            }

            if (input[i] == ')')
            {
                countOfCloseBracets++;

                if (countOfCloseBracets > countOfOpenBrackets)
                {
                    isCorrect = "Incorrect";
                    break;
                }
            }
        }

        if (countOfOpenBrackets > countOfCloseBracets)
        {
            isCorrect = "Incorrect";
        }
        return isCorrect;
    }


    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(IsCorrectBrackets(input));
    }
}
