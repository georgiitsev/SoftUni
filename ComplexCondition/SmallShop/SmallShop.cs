using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quality = double.Parse(Console.ReadLine());
           
            if (city == "sofia")
            {
                if (product == "coffee" )
                {
                    
                    Console.WriteLine(0.5 * quality);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 *quality);
                }
                else if (product == "peanuts" )
                {
                    Console.WriteLine(1.6 * quality);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 *quality);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * quality);
                }
            }
            if (city == "plovdiv")
            {
                if (product == "coffee" )
                {
                    Console.WriteLine(0.4 * quality);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 *quality);
                }
                else if (product == "peanuts" )
                {
                    Console.WriteLine(1.5 * quality);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * quality);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quality);
                }
            }
            if (city == "varna" )
            {
                if (product == "coffee" )
                {
                    
                    Console.WriteLine(0.45 * quality);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.10 *quality);
                }
                else if (product == "peanuts" )
                {
                    Console.WriteLine(1.55 * quality);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35*quality);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quality);
                }
            }
	
        }
    }
}
