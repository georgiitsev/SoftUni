using System;

namespace ValeyBall
{
    class ValeyBall
    {
        static void Main()
        {
            string yearLeapOrNormal = Console.ReadLine();
            int numberOfHollydayExceptSundayAndSaturday = int.Parse(Console.ReadLine());
            int numberOfWeekendToHomeTown = int.Parse(Console.ReadLine());
            const double seventyFivePercentWeekendInSofia = 3.0 / 4;
            const double sixtySixPercentGamesInHollyday = 2.0 / 3;
            const double allYearWeekend = 48;
            double numberOfGamesInSofia = (48 - numberOfWeekendToHomeTown) * seventyFivePercentWeekendInSofia;
            double numberOfGamesInHomeTown = numberOfWeekendToHomeTown;
            double numberOfGamesInHollydays = numberOfHollydayExceptSundayAndSaturday * sixtySixPercentGamesInHollyday;
            double allGamesInTheYear = numberOfGamesInSofia + numberOfGamesInHomeTown + numberOfGamesInHollydays;

            switch (yearLeapOrNormal)
            {
                case "leap":
                    allGamesInTheYear+= allGamesInTheYear * 0.15;
                    Console.WriteLine(Math.Truncate(allGamesInTheYear));
                    break;
                case "normal":
                    Console.WriteLine(Math.Truncate(allGamesInTheYear));
                    break;
                default:
                    break;
            }
        }
    }
}
