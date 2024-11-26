using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises
{
    internal class StringEx
    {
        static void Main()
        {
            new StringConcat().Execute();


            var text = "   Lorem ipsum dolor sit amet, consectetur   adipiscing elit.\n";

            //
            var wordsCount = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            wordsCount = text.Split(new[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //
            var textToComma = text.Substring(0, text.IndexOf(","));
            var textAfterComma = text.Substring(text.IndexOf(",") + 1).Trim();
            //
            var thirdWord = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

            //
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var newText = "";
            for (int i = 0; i < words.Length; i = i + 2)
            {
                newText += words[i] + " ";
            }

            //
            var counter = 0;
            foreach (var word in text.ToLower())
            {
                if (word == 'e')
                {
                    counter++;
                }
            }
            //counter = text.Count(x => x == 'e');




        }

        bool IsMatch(int x)
        {
            return x == 'e';
        }
    }
}
