using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises
{

    public class StringConcat
    {
        public void Execute()
        {
            var test = new StringConcat();
            var loopCount = 500_000;
            var timer = Stopwatch.StartNew();

            test.ConcatUsingString(loopCount);
            Console.WriteLine($"Concatenating strings took {timer.ElapsedMilliseconds} ms.");
            timer.Restart();
            test.ConcatWithStringBuilder(loopCount);
            Console.WriteLine($"Concatenating StringBuilder took {timer.ElapsedMilliseconds} ms.");
            //timer.Reset();

        }

        public void ConcatUsingString(int count)
        {
            var str = string.Empty;
            for (int i = 0; i < count; i++)
            {
                str += " ";
            }
        }

        public void ConcatWithStringBuilder(int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(" ");
                
            }
            var text = sb.ToString();
        }
    }
}
