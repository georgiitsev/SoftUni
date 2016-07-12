using System;

namespace SummerVacation
{
    class Traveling
    {
        static void Main()
        {
            const double percentFromBudjetInSummerBulgaria = 0.3;
            const double percentFromBudjetInWinterBulgaria = 0.7;
            const double percentFromBudjetInSummerBalkans = 0.4;
            const double percentFromBudjetInWinterBalkans = 0.8;
            const double percentFromBudjetInAnySeasoneEurope = 0.9;
            string destinationBulgaria = "Somewhere in Bulgaria";
            string destinationBalkan = "Somewhere in Balkans";
            string destinationEurope = "Somewhere in Europe";
            string bulding = "Camp";
            string placeVacation = "Hotel";
            double result = 0.00;

            double budjetForVacation = double.Parse(Console.ReadLine());
            string sesoneDistination = Console.ReadLine();


            if (budjetForVacation <= 100)
            {
                switch (sesoneDistination)
                {
                    case "summer":

                        result = budjetForVacation * percentFromBudjetInSummerBulgaria;
                        Console.WriteLine(destinationBulgaria);
                        Console.WriteLine("{0} - {1:f2}", bulding, result);
                        break;
                    case "winter":
                        result = budjetForVacation * percentFromBudjetInWinterBulgaria;
                        Console.WriteLine(destinationBulgaria);
                        Console.WriteLine("{0} - {1:f2}", placeVacation, result);
                        break;
                    default:
                        break;
                }
            }
            else if (budjetForVacation <= 1000 && budjetForVacation > 100)
            {
                switch (sesoneDistination)
                {
                    case "summer":

                        result = budjetForVacation * percentFromBudjetInSummerBalkans;
                        Console.WriteLine(destinationBalkan);
                        Console.WriteLine("{0} - {1:f2}", bulding, result);
                        break;
                    case "winter":
                        result = budjetForVacation * percentFromBudjetInWinterBalkans;
                        Console.WriteLine(destinationBalkan);
                        Console.WriteLine("{0} - {1:f2}", placeVacation, result);
                        break;
                    default:
                        break;
                }
            }
            else if (budjetForVacation > 1000)
            {
                result = budjetForVacation * percentFromBudjetInAnySeasoneEurope;
                Console.WriteLine(destinationEurope);
                Console.WriteLine("{0} - {1:f2}", placeVacation, result);
            }
        }
    }
}
