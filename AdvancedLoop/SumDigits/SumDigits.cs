using System;

namespace SumDigits
{
    class SumDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string str = number.ToString();
            int sumNUmber = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sumNUmber += number % 10;
                number = number / 10;

            }
            Console.WriteLine(sumNUmber);
        }
    }
}
