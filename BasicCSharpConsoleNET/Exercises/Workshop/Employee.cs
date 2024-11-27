using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    public abstract record Employee
    {
        public string Name { get; set; }
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Obliczam wypłatę dla " + Name + ".");
        }
    }

    public record Secretary : Employee
    {
        public override void CalculateSalary()
        {
            this.CalculateSalary();
            Console.WriteLine("Wypłata to Sekretarza 5000");
        }
    }
    public record Director : Employee
    {
        public override void CalculateSalary()
        {
            this.CalculateSalary();
            Console.WriteLine("Wypłata to Sekretarza 8000");
        }

        public void GetBonus()
        {
            Console.WriteLine("Wypłata bonusu 2000");
        }
    }
    public record Programmer : Employee
    {
        public override void CalculateSalary()
        {
            this.CalculateSalary();
            Console.WriteLine("Wypłata to Sekretarza 6000");
        }
    }


    public class TestEmployee
    {
        public static void Main()
        {
            var dir = new Director(){ Name = "John" };
            var sec1 = new Secretary() { Name = "Alan" };
            var sec2 = new Secretary() { Name = "Dan" };
            var prog1 = new Programmer() { Name = "Matt" };
            var prog2 = new Programmer() { Name = "Joe" };

            var employees = new Employee[] {dir, sec1, sec2, prog1, prog2};

            foreach (var employee in employees)
            {
                employee.CalculateSalary();

                //if(employee is Director)
                //{
                //    var director = (Director)employee;

                //    director.GetBonus();
                //}

                var director = employee as Director;
                director?.GetBonus();  // ?.
                //if(director != null)
                //{
                //    director.GetBonus();
                //}
            }
        }
    }

}
