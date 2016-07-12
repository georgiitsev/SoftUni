using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int firstRacer = int.Parse(Console.ReadLine());
            int secondRacer = int.Parse(Console.ReadLine());
            int thirdRacer = int.Parse(Console.ReadLine());
            int sum = firstRacer + secondRacer + thirdRacer;
            int minutes = 0;
            int seconds = 0;

            if (firstRacer >= 1 && firstRacer <= 50 && secondRacer >= 1 && secondRacer <= 50 && thirdRacer >= 1 && thirdRacer <= 50)
            {
                if (sum <= 59)
                {
                    if (sum < 10)
                    {
                        Console.WriteLine("{0}:{2}{1}", minutes, sum, 0);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", minutes,sum);
                    }
                }
                else
                {
                    minutes = sum / 60;
                    seconds = sum - (minutes * 60);
                    if (seconds < 10)
                    {
                        Console.WriteLine("{0}:{2}{1}", minutes, seconds,0);
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}",minutes,seconds);
                    }

                }
            }
            else
            {
                return;
            }
        }
    }
}
