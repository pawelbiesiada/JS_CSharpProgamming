using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class RainFall
    {
        private int[] _falls = new int[12];

        public int Average 
        { 
            get 
            {
                var sum = 0;
                foreach (var item in _falls)
                {
                    sum += item;
                }

                return sum / _falls.Length;
            } 
        }


        public int GetAverage()
        {
            var sum = 0;
            foreach (var item in _falls)
            {
                sum += item;
            }

            return sum / _falls.Length;            
        }

        public int GetMonthyRainFall(int month)
        {
            var avg = Average;


            if(month < 1 || month > 12)
                return 0;

            return _falls[month - 1];
        }

        public void AddRainFall(int month, int fall)
        {
            if (month < 1 || month > 12)
                return;

            _falls[month - 1] = fall;
        }
    }
}
