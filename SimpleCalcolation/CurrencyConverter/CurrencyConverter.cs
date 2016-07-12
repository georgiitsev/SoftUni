using System;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            Console.WriteLine("Value");
            var value = double.Parse(Console.ReadLine());
            Console.WriteLine("currency");
            var currency = Console.ReadLine();
            Console.WriteLine("Scurr");
            var Scurrency = Console.ReadLine();
            double BGN, EUR, USD, GBP;
            while (currency == "BGN")
            {
                if (Scurrency == "EUR")
                {
                    EUR = value / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), Scurrency);
                    break;
                }
                if (Scurrency == "USD")
                {
                    USD = value / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), Scurrency);
                    break;
                }
                if (Scurrency == "GBP")
                {
                    GBP = value / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), Scurrency);
                    break;
                }
            }
            while (currency == "EUR")
            {
                if (Scurrency == "BGN")
                {
                    BGN = 1.95583 * value;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), Scurrency);
                    break;
                }
                if (Scurrency == "USD")
                {
                    USD = (1.95583 * value) / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), Scurrency);
                    break;
                }
                if (Scurrency == "GBP")
                {
                    GBP = (1.95583 * value) / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), Scurrency);
                    break;
                }
            }
            while (currency == "USD")
            {
                if (Scurrency == "BGN")
                {
                    BGN = 1.79549 * value;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), Scurrency);
                    break;
                }
                if (Scurrency == "EUR")
                {
                    EUR = (1.79549 * value) / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), Scurrency);
                    break;
                }
                if (Scurrency == "GBP")
                {
                    GBP = (1.79549 * value) / 2.53405;
                    Console.WriteLine("{0} {1}", Math.Round(GBP, 2), Scurrency);
                    break;
                }
            }
            while (currency == "GBP")
            {
                if (Scurrency == "BGN")
                {
                    BGN = 2.53405 * value;
                    Console.WriteLine("{0} {1}", Math.Round(BGN, 2), Scurrency);
                    break;
                }
                if (Scurrency == "EUR")
                {
                    EUR = (2.53405 * value) / 1.95583;
                    Console.WriteLine("{0} {1}", Math.Round(EUR, 2), Scurrency);
                    break;
                }
                if (Scurrency == "USD")
                {
                    USD = (2.53405 * value) / 1.79549;
                    Console.WriteLine("{0} {1}", Math.Round(USD, 2), Scurrency);
                    break;
                }

            }
        }
    }
}
