using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double totalSum = 0.0;

            if (dayOfWeek == "Friday" || dayOfWeek == "Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Tuesday" || dayOfWeek == "Thursday")
            {
                double banana = 2.50;
                double apple = 1.20;
                double orange = 0.85;
                double grapefruit = 1.45;
                double kiwi = 2.70;
                double pineapple = 5.50;
                double grapes = 3.85;

                if (fruit == "banana")
                {
                    totalSum = quality * banana;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "apple")
                {
                    totalSum = quality * apple;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "orange")
                {
                    totalSum = quality * orange;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "grapefruit")
                {
                    totalSum = quality * grapefruit;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "kiwi")
                {
                    totalSum = quality * kiwi;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "pineapple")
                {
                    totalSum = quality * pineapple;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "grapes")
                {
                    totalSum = quality * grapes;
                    Console.WriteLine(totalSum);
                }
               
            }
            else
            {
                Console.WriteLine("error");
            }
            if (dayOfWeek == "Sunday" || dayOfWeek == "Saturday")
            {
                double banana = 2.70;
                double apple = 1.25;
                double orange = 0.90;
                double grapefruit = 1.60;
                double kiwi = 3.00;
                double pineapple = 5.60;
                double grapes = 4.20;

                if (fruit == "banana")
                {
                    totalSum = quality * banana;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "apple")
                {
                    totalSum = quality * apple;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "orange")
                {
                    totalSum = quality * orange;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "grapefruit")
                {
                    totalSum = quality * grapefruit;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "kiwi")
                {
                    totalSum = quality * kiwi;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "pineapple")
                {
                    totalSum = quality * pineapple;
                    Console.WriteLine(totalSum);
                }
                else if (fruit == "grapes")
                {
                    totalSum = quality * grapes;
                    Console.WriteLine(totalSum);
                }
                
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
