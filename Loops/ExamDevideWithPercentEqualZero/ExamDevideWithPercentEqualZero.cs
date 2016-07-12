using System;

namespace ExamDevideWithPercentEqualZero
{
    class ExamDevideWithPercentEqualZero
    {
        static void Main()
        {
            int lengthOfLoop = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < lengthOfLoop; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double finalResultP1 = (p1 / lengthOfLoop) * 100;
            double finalResultP2 = (p2 / lengthOfLoop) * 100;
            double finalResultP3 = (p3 / lengthOfLoop) * 100;

            PrintFinalResult(finalResultP1, finalResultP2, finalResultP3);
        }

        private static void PrintFinalResult(double finalResultP1, double finalResultP2, double finalResultP3)
        {
            string percent = "%";
            Console.WriteLine("{0:f2}{1}", finalResultP1, percent);
            Console.WriteLine("{0:f2}{1}", finalResultP2, percent);
            Console.WriteLine("{0:f2}{1}", finalResultP3, percent);

        }
    }
}
