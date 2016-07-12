using System;

namespace PriceForTravel
{
    class PriceForTravel
    {
        static void Main()
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            if (kilometers > 1 && kilometers < 5000)
            {
                if (kilometers < 20)
                {
                    if (dayOrNight == "day")
                    {
                        double price = (kilometers * 0.79) + 0.70;
                        Console.WriteLine(price);
                    }
                    else
                    {
                        double price = (kilometers * 0.90) + 0.70;
                        Console.WriteLine(price);
                    }
                }
                if (kilometers >= 20 && kilometers < 100)
                {
                    double price = kilometers * 0.09;
                    Console.WriteLine(price);
                }
                if (kilometers >= 100)
                {
                    double price = kilometers * 0.06;
                    Console.WriteLine(price);
                }
            }

        }
    }
}
