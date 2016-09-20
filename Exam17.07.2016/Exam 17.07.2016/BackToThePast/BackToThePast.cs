using System;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main()
        {
            int spendingMoneyForEvenYear = 12000;
            int oddYear = 50;
            int year = 1800;
            int ivanYear = 18;
            decimal money = decimal.Parse(Console.ReadLine());
            int yearsToLiveInclude = int.Parse(Console.ReadLine());
            decimal result = money;


            for (int i = year; i <= yearsToLiveInclude; i++)
            {
                if (i % 2 == 0)//even years
                {
                    result = result - spendingMoneyForEvenYear;
               
                }
                else
                {
                     result = result - spendingMoneyForEvenYear;
                    result = result - (ivanYear * oddYear);
                   
                }
                ivanYear++;
            }
            if (result >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", result);
            }
            else if (result < 0)
            {

                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(result));
            }

        }

    }
}
