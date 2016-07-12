using System;

namespace Comission
{
    class Comission
    {
        static void Main()
        {
            const double commisionSofiaUnder500 = 0.05;
            const double commisionSofiaBetween500and1000 = 0.07;
            const double commisionSofiaBetween1000and10000 = 0.08;
            const double commisionSofiaGreaterthan10000 = 0.12;

            const double commisionVarnaUnder500 = 0.045;
            const double commisionVarnaBetween500and1000 = 0.075;
            const double commisionVarnaBetween1000and10000 = 0.10;
            const double commisionVarnaGreaterThan10000 = 0.13;

            const double commisionPlovdivUnder500 = 0.055;
            const double commisionPlovdivBetween500and1000 = 0.08;
            const double commisionPlovdivBetween1000and10000 = 0.12;
            const double commisionPlovdivGreaterthan10000 = 0.145;
            

            string town = Console.ReadLine().ToLower();
            double cell = double.Parse(Console.ReadLine());
            double totalCommision = 0.00;

            if (town == "sofia")
            {
                if (cell >=0 && cell<=500)
                {
                    totalCommision = cell * commisionSofiaUnder500;
                    Console.WriteLine("{0:f2}",totalCommision);
                }
                else if (cell > 500 && cell <= 1000)
                {
                    totalCommision = cell * commisionSofiaBetween500and1000;
                    Console.WriteLine("{0:f2}",totalCommision);
                }
                else if (cell > 1000 && cell <= 10000)
                {
                    totalCommision = cell * commisionSofiaBetween1000and10000;
                    Console.WriteLine("{0:f2}",totalCommision);
                }
                else if (cell > 10000)
                {
                    totalCommision = cell * commisionSofiaGreaterthan10000;
                    Console.WriteLine("{0:f2}",totalCommision);
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }

            else if (town == "varna")
            {
                if (cell >= 0 && cell <= 500)
                {
                    totalCommision = cell * commisionVarnaUnder500;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 500 && cell <= 1000)
                {
                    totalCommision = cell * commisionVarnaBetween500and1000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 1000 && cell <= 10000)
                {
                    totalCommision = cell * commisionVarnaBetween1000and10000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 10000)
                {
                    totalCommision = cell * commisionVarnaGreaterThan10000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            else if (town == "plovdiv")
            {
                if (cell >= 0 && cell <= 500)
                {
                    totalCommision = cell * commisionPlovdivUnder500;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 500 && cell <= 1000)
                {
                    totalCommision = cell * commisionPlovdivBetween500and1000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 1000 && cell <= 10000)
                {
                    totalCommision = cell * commisionPlovdivBetween1000and10000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else if (cell > 10000)
                {
                    totalCommision = cell * commisionPlovdivGreaterthan10000;
                    Console.WriteLine("{0:f2}", totalCommision);
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
