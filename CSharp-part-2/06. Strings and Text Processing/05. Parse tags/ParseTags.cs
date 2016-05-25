using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseTags
{
    static void Main()
    {
        var text = Console.ReadLine();

        var lengthOfFirstTag = "<upcase>".Length;

        var indexX = text.IndexOf("<upcase>");
        var indexY = text.IndexOf(@"</upcase>");

        var indexXLength = text.IndexOf("<upcase>") + lengthOfFirstTag;

        var lengthOfWord = indexY - indexXLength;
        var textBetweenTheTags = text.Substring(indexXLength, lengthOfWord);
        var upperText = textBetweenTheTags.ToUpper();
        var fixedtext = text.Replace(textBetweenTheTags, upperText);
        fixedtext = fixedtext.Replace("<upcase>", string.Empty);
        fixedtext = fixedtext.Replace(@"</upcase>", string.Empty);

        while (indexX != -1)
        {
            indexX = text.IndexOf("<upcase>", indexX + 1);
            indexX + indexXLength
        }

        Console.WriteLine(fixedtext);
        

    }
}
