using System;
using System.Collections.Generic;
using BasicCSharpConsoleNET.Samples.Class.Inheritance;
using BasicCSharpConsoleNET.Samples.Patterns;
using BasicCSharpConsoleNET.Samples.SOLID;

namespace BasicCSharpConsoleNET.Samples.Class
{

    class Bike : IVehicle
    {
        public int Distance => throw new NotImplementedException();

        public void Drive(int duration)
        {
            throw new NotImplementedException();
        }

        public bool IsServiceCheckNeeded()
        {
            throw new NotImplementedException();
        }
    }

    public class Car : IVehicle
    {
        //Constant Field
        private const int ServiceCheckAfter = 10_000;

        // Fields
        protected readonly int _speed;

        public string VIN { get; set; }

        // Properties
        public int Distance { get; set; }

        public static int StaticDistance { get; set; }

        // Constructor
        public Car()
        {
            _speed = 1;
        }

        public Car(int avgSpeed)
        {
            //var car = new Car(100); initialization sample
            _speed = avgSpeed;
        }
        public Car(int avgSpeed, ILogger logger)
        {
            //var car = new Car(100); initialization sample
            _speed = avgSpeed;
        }

        // Methods
        public void Drive(int duration)
        {
            Distance += CalculateDistance(_speed, duration);
            StaticDistance += CalculateDistance(_speed, duration);
        }

        public virtual bool IsServiceCheckNeeded()
        {
            return Distance > ServiceCheckAfter;
        }

        private static int CalculateDistance(int speed, int duration)
        {
            return speed * duration;
        }


        public override bool Equals(object obj)
        {
            if (obj is not Car)
            {
                return false;
            }

            var c = (Car)obj;

            return this.VIN == c.VIN && this.Distance == c.Distance;
        }

    }

    public class ClassTest
    {
        public class MyClass
        {
            public MyClass(int i) { }
            public MyClass() { }
        }
        public static void Main()
        {
            var mc = new MyClass();

            var c = new Car();


            c.DriveLong();


            var b = new Bike();
            b.DriveLong();

            Car car = new Car(30);
            Car car2 = new Car(50);
            Car car3 = new Car(30);



            car.Drive(2);
            car2.Drive(2);
            car3.Drive(2);


            var myLocalVariable = car2;

            myLocalVariable.Drive(10);
            myLocalVariable = car3;
            myLocalVariable.Drive(10);



            int i1 = 3;
            int i2 = 5;

            int myLocalInt = i1;

            myLocalInt = 10;



            var isEq = myLocalVariable == car2;


            ModifyClass(car);


            ModifyClass(car.Distance);



            car.Drive(10);


            myLocalVariable.Drive(10);

            var areEqual = car == car2; //
            areEqual = car == car3; //

            areEqual = car.Equals(car2); //false
            areEqual = car.Equals(car3); //false

            car.Distance = 50;
            areEqual = car.Equals(car2); //false
            areEqual = car.Equals(car3); //false

            var copyCar = car;
            areEqual = car.Equals(copyCar); //true
            car.Distance = 10;
            areEqual = car.Equals(copyCar); //true

            ModifyClass(car);
            areEqual = car.Distance == 100; // true

            ModifyAndInitializeClass(car);
            areEqual = car.Distance == 200; // true
            areEqual = car.Distance == 300; // false
        }

        public static void ModifyClass(Car car)
        {
            car.Distance = 100;
        }


        public static void ModifyClass(IVehicle v)
        {
            v.Drive(3);
        }


        public static void ModifyClass(int dist)
        {
            dist = 100;
        }

        //car.Distance = 100;
        //ModifyAndInitializeClass(car);
        // car.Distance == 200
        public static void ModifyAndInitializeClass(Car car)
        {
            car.Distance = 200;

            car = new Car(300);
            //car.Distance == 0
        }
    }
}
