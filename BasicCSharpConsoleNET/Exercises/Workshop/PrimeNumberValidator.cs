using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public class PrimeNumberValidator
    {
        public bool IsPrimeNumber(int number)
        {
            var result = false;

            int a = 0, i = 2;
            while (i <= number)
            {
                if (number % i == 0)
                {
                    a++;
                }
                if (a == 2)
                {
                    break;
                }
                i++;
            }

           return a == 1;
        }



        public bool IsPrimeNumber2(int number)
        {
            if(number <= 2 )
                return false;

            //var result = true;          
            //for (int j = 2; j < number; j++)
            //{
            //    if (number % j == 0)
            //    {
            //        result = false;
            //        break;
            //    }
            //}
            //return result;

            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    return false;
                }
                i++;
            }

            return true;
        }
    }
}
