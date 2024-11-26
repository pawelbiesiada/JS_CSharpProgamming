using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class Robot
    {
        public bool IsOn { get; set; }

        public string Name { get; private set; }

        public int Age { get; set; }

        public Robot(string name, ushort age, bool isOn) : this(name, age)
        {
            IsOn = isOn;
        }

        /// <summary>
        /// Inicjalizuje klase robot z parametrami zadanymi. IsOn domyslnie będzie true
        /// </summary>
        /// <param name="name"> </param>
        /// <param name="age"> </param>
        public Robot(string name, ushort age) : this()
        {
            Name = name;
            Age = age;
           
        }

        private Robot()
        {
            IsOn = true;
        }

        /// <summary>
        /// Witam się
        /// </summary>
        public void SayHi()
        {
            if(IsOn)
            {
                Console.WriteLine($"Hi {Name}");
            }
        }
    }

    class RobotTest
    { 
        public void Test()
        {
            //var robot = new Robot()
            //{
            //    Age = 1,
            //    IsOn = true,
            //  //  Name = "Test"
            //};

            var robot2 = new Robot("Test2", 2);


            robot2.SayHi();
        }
    }

}
