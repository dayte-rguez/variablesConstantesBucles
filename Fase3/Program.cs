using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //Show the leap years between 1948 and the birthyear
            for (i = Constants.firstLeapYear; i <= Constants.birthYear; i += Constants.newLeapYear)
            {
                Console.WriteLine($"{i}");
            }

            //Show if the birthyear is leap
            var leapBirthYear = false;
            if (i == Constants.birthYear + Constants.newLeapYear)
            {
                leapBirthYear = !leapBirthYear;
                Console.WriteLine($"The birthyear {Constants.birthYear} is leap");
            }
            else
            {
                Console.WriteLine($"The birthyear {Constants.birthYear} is not leap");
            }

        }
    }
    static class Constants
    {
        public const int firstLeapYear = 1948;
        public const int newLeapYear = 4;
        public const int birthYear = 1983;
    }
}
