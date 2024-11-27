namespace BasicCSharpConsoleNET.Exercises.Workshop
{
    internal class RainFall
    {
        private int[] _falls = new int[12];
        public int this[int month]
        {
            get
            {
                return GetMonthlyRainFall(month);
            }
            set
            {
                AddRainFall(month, value);
            }
        }

        public int this[string month]
        {
            get
            {
                if (month.Equals("January"))
                    return GetMonthlyRainFall(1);

                return 0;
            }
            set
            {
                if (month.Equals("January"))
                    AddRainFall(1, value);
            }
        }

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
                //return (int)_falls.Average();
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

        public int GetMonthlyRainFall(int month)
        {
            if(month < 1 || month > 12)
                return 0;

            return _falls[month - 1];
        }

        public int GetMonthlyRainFall(Month month)
        {
            return GetMonthlyRainFall((int)month);
        }

        public void ImportRainFall(RainFall rainFall)
        {
            for (int i = 0; i < _falls.Length; i++)
            {
                _falls[i] += rainFall._falls[i];
            }

            RainFall a = new RainFall();
            RainFall b = new RainFall();

            var c = a + b;
        }

        public void AddRainFall(int month, int fall)
        {
            if (month < 1 || month > 12)
                return;

            _falls[month - 1] = fall;

            GetMonthlyRainFall(Month.March);
            GetMonthlyRainFall(3);
        }


        public static RainFall operator +(RainFall a, RainFall b)
        {
            var c = new RainFall();

            c.ImportRainFall(a);
            c.ImportRainFall(b);

            return c;

            var fall = c["January"];
        }

    }

    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May
    }

    public enum UserStatus
    {
        Active = 0,
        /// <summary>
        /// Nadawany po rejestracji
        /// </summary>
        NonActive = 1,
        /// <summary>
        /// Status nadawany za zle uzycie aplikacji
        /// </summary>
        Blocked = 2
    }
}
