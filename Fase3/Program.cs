using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show the leap years between 1948 and the birthyear
            for (var i = Constants.firstLeapYear; i <= 1983; i += Constants.newLeapYear)
            {
                Console.WriteLine($"{i}");
            }
            
        }
    }
    static class Constants
    {
        public const int firstLeapYear = 1948;
        public const int newLeapYear = 4;
    }
}
