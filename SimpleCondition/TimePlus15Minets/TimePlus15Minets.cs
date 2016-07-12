using System;

namespace TimePlus15Minets
{
    class TimePlus15Minets
    {
        static void Main()
        {
           int hours = int.Parse(Console.ReadLine());
            int minets = int.Parse(Console.ReadLine());

            TimeSpan clock = new TimeSpan(hours,minets +15 ,0);
            Console.WriteLine("{0:%h}:{0:mm}",clock);
        }
    }
}
