using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class Fibo
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Musisz podać wartość");
                return;
            }

            var arg1 = args[0];

            var number = int.Parse(arg1);

            Console.WriteLine($"Najmniejsza liczba Fibonacciego większa od {number} to: {GetNextFibo(number)}");

        }

        public static int GetNextFibo(int numberToEvaluate)
        {
            var n1 = 1;
            var n2 = 1;

            var nextFib = 0;

            while (nextFib <= numberToEvaluate)

            {
                nextFib = n1 + n2;
                n1 = n2;
                n2 = nextFib;
            }


            return nextFib;
        }
    }


}