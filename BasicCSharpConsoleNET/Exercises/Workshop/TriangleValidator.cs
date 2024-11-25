using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class TriangleValidator
    {
        static void Main()
        {
            Console.Write("Podaj pierwszy bok: ");
            var strA = Console.ReadLine();

            var isParsed = Double.TryParse(strA, out var a); //out, ref
            if (!isParsed)
            {
                var retryCounter = 3;

                while(!Double.TryParse(strA, out a) && retryCounter > 0)
                {
                    retryCounter--;
                    Console.WriteLine($"Wartość: '{strA}' nie jest liczbą, podaj wartość poprawną");
                    strA = Console.ReadLine();
                }

                if(retryCounter == 0)
                {
                    return;
                }
            }


            Console.Write("Podaj drugi bok: ");
            var strB = Console.ReadLine();

            isParsed = Double.TryParse(strB, out var b); //out, ref
            if (!isParsed)
            {
                Console.WriteLine("Wartość nie jest liczbą");
                return;
            }


            Console.Write("Podaj trzeci bok: ");
            var strC = Console.ReadLine();

            isParsed = Double.TryParse(strC, out var c); //out, ref
            if (!isParsed)
            {
                Console.WriteLine("Wartość nie jest liczbą");
                return;
            }

            if (CanBeATriangle(a, b, c))
            {
                Console.WriteLine($"Z boków {a}, {b}, {c} można utworzyć trójkąt");
            }
            else
            {
                Console.WriteLine($"Z boków {a}, {b}, {c} nie można utworzyć trójkąta");
            }

            Console.ReadLine();
        }

        //2,3,4
        public static bool CanBeATriangle(double edgeA, double edgeB, double edgeC)
        {
            return edgeA + edgeB > edgeC && //2 + 3 > 4
                edgeA + edgeC > edgeB &&    // 2 + 4 > 3
                edgeC + edgeB > edgeA;     // 3 + 4 > 2
        }

        public static bool CanBeATriangle2(double edgeA, double edgeB, double edgeC)
        {
            var collection = new[] {edgeA, edgeB, edgeC};
            var sortedCollection = collection.Order();

            return collection[0] + collection[1] > collection[2];
        }
    }
}
