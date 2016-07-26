using System;

namespace CHarvest
{
    class Harvest
    {
        static void Main()
        {
            const double percentForWine = 0.4;
            const double neceseryForOneLitter = 2.5;

            int allAreaOfWinary = int.Parse(Console.ReadLine());
            double grapeForOneMeter = double.Parse(Console.ReadLine());
            int necesaryWineLiters = int.Parse(Console.ReadLine());
            int numbersOfWorker = int.Parse(Console.ReadLine());
            double finalToLower = 0.00;
            double finalToGreater = 0.00;


            double allGraope = allAreaOfWinary * grapeForOneMeter;
            double middleresult = (allGraope * percentForWine) / neceseryForOneLitter;
            if (middleresult < necesaryWineLiters)
            {
                finalToLower =Math.Abs(middleresult - necesaryWineLiters);

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Truncate(finalToLower));
            }
            else
            {
                finalToGreater = middleresult - necesaryWineLiters;
                double finalResult = finalToGreater / numbersOfWorker;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Round(middleresult));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Round(finalToGreater,finalResult));

            }
            

        }
    }
}
