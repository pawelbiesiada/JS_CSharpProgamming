using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class AppConfiguration
    {
        private string DomyslnyJezykAplikacji = "pl";

        public string JezykAplikacji { get; private set; }

        public AppConfiguration()
        {
            JezykAplikacji = DomyslnyJezykAplikacji;
        }

        public AppConfiguration(string filePath) : this()
        {
            string item = LoadItem(filePath);
            if (item != null)
                    JezykAplikacji = item ;

            //JezykAplikacji = LoadItem(filePath) ?? DomyslnyJezykAplikacji;
        }

        private string LoadItem(string filePath)
        {
            return null; ///
        }
    }
}
