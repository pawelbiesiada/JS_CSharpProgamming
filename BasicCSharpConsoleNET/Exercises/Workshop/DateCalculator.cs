using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class DateCalculator
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pl-pl");

            //podaj datę
            Console.WriteLine($"Podaj datę w formacie: {CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}");
            var dateStr = Console.ReadLine();
            if (!DateTime.TryParse(dateStr, out var date))
            {
                Console.WriteLine("Zły format");
                return;
            }
            //oblicz ile dni minęło od podanej daty do dzisiaj
            var timePassed = DateTime.Now - date;

            //wypisz datę na konsolę w formacie polskim wraz z informacją o liczbie dni (i ew. godzin)
            Console.WriteLine("Od dnia " + date.ToShortDateString() + " minęło " + timePassed.Days + " dni ( "+ timePassed.Hours + " godzin).");
        }
    }
}
