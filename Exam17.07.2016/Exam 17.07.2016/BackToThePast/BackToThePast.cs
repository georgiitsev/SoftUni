using System;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main()
        {
            const int spendingMoneyForEvenYear = 12000;
            const int oddYear = 50;
            int year = 1800;
            int ivanYear = 18;
            double money = double.Parse(Console.ReadLine());
            int yearsToLiveInclude = int.Parse(Console.ReadLine());
            double result = money;
            

            for (int i = year; i <= yearsToLiveInclude; i++)
            {
                if (i % 2 == 0)
                {
                 result = result - spendingMoneyForEvenYear;
                }
                else
                {
                    result = result - (spendingMoneyForEvenYear+ (ivanYear * 50));
                }
                ivanYear++;
            }
            if (result > 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",Math.Abs(result));
            }
            else if (result < 0)
            {
                
                Console.WriteLine("He will need {0} dollars to survive.",Math.Abs(result));
            }
            
        }

    }
}
