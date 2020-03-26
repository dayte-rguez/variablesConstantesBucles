﻿using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show the leap years between 1948 and the birthyear
            var lastLeap = showLeaps();

            //Show if the birthyear is leap
            isBirthyearLeap(lastLeap);
        }

        private static void isBirthyearLeap(int aLastLeap)
        {
            var leapBirthYear = aLastLeap == Constants.birthYear;

            if (leapBirthYear)
            {
                Console.WriteLine($"The birthyear {Constants.birthYear} is leap");
            }
            else
            {
                Console.WriteLine($"The birthyear {Constants.birthYear} is not leap");
            }
        }

        private static int showLeaps()
        {
            int i;
            for (i = Constants.firstLeapYear; i <= Constants.birthYear; i += Constants.newLeapYear)
            {
                Console.WriteLine($"{i}");
            }

            return i - Constants.newLeapYear;
        }
    }
    static class Constants
    {
        public const int firstLeapYear = 1948;
        public const int newLeapYear = 4;
        public const int birthYear = 1983;
    }
}
