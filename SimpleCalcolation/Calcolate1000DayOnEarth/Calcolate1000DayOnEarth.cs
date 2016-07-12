using System;
using System.Globalization;

namespace Calcolate1000DayOnEarth
{
    class Calcolate1000DayOnEarth
    {
        static void Main()
        {
            string dt = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dt, "dd-MM-yyyy",null);
           DateTime after = date.AddDays(999);
            Console.WriteLine(after.ToString("dd-MM-yyyy"));
        }
    }
}
