using System;

namespace Cinema
{
    class TicketPrice
    {
        static void Main()
        {
            string nameOfCurrencyInBgn = "leva";
            string kindOfProjection = Console.ReadLine();
            double numberOfColumnsInHall = double.Parse(Console.ReadLine());
            double numberOfRowsInHall = double.Parse(Console.ReadLine());
            double totalIncomeOfProjection = 0.00;
            double resultOfMultiplyRowAndCow = (numberOfColumnsInHall * numberOfRowsInHall);
            const double priceForProjectionPremiereMode = 12.00;
            const double priceForProjectionNormalMode = 7.50;
            const double priceForProjectionDiscountMode = 5.00;

            switch (kindOfProjection)
            {
                case "Premiere":
                    totalIncomeOfProjection = Math.Round(resultOfMultiplyRowAndCow * priceForProjectionPremiereMode, 2);
                    Console.WriteLine("{1:f2} {0}",nameOfCurrencyInBgn,totalIncomeOfProjection);
                    break;
                case "Normal":
                    totalIncomeOfProjection = Math.Round(resultOfMultiplyRowAndCow * priceForProjectionNormalMode, 2);
                    Console.WriteLine("{1:f2} {0}",nameOfCurrencyInBgn,totalIncomeOfProjection);
                    break;
                case "Discount":
                    totalIncomeOfProjection = Math.Round(resultOfMultiplyRowAndCow * priceForProjectionDiscountMode, 2);
                    Console.WriteLine("{1:f2} {0}",nameOfCurrencyInBgn,totalIncomeOfProjection);
                    break;

                default:
                    break;
            }

        }
    }
}
