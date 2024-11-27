using BasicCSharpConsoleNET.Samples.Class.Inheritance;

namespace BasicCSharpConsoleNET.Samples.Class
{
    public static class ExtensionMethods
    {
        public static void WorkHard(this Bulldozer bulldozer)
        {
            while (!bulldozer.IsServiceCheckNeeded())
            {
                bulldozer.DoSomeWork();
            }
        }



        public static string WorkHard(this Bulldozer bulldozer, int times)
        {
            var b = new Bulldozer();





            while (!bulldozer.IsServiceCheckNeeded() && times > 0)
            {
                bulldozer.DoSomeWork();
                times--;
            }

            return "Work completed";
        }


        public static void DriveLong(this IVehicle v)
        {

            v.Drive(500);
        }


        public static bool IsValidEmailAddress(this string email)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(email);
        }
    }
}
