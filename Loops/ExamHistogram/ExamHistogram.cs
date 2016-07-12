using System;

namespace ExamHistogram
{
    class ExamHistogram
    {
        static void Main()
        {
            int lengthOfLoop = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < lengthOfLoop; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number > 0 && number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800 && number <= 1000)
                {
                    p5++;
                }

            }
            double finalResultP1 = (p1 / lengthOfLoop) * 100;
            double finalResultP2 = (p2 / lengthOfLoop) * 100;
            double finalResultP3 = (p3 / lengthOfLoop) * 100;
            double finalResultP4 = (p4 / lengthOfLoop) * 100;
            double finalResultP5 = (p5 / lengthOfLoop) * 100;

            PrintResultsOfP1P2P3P4P5(finalResultP1, finalResultP2, finalResultP3, finalResultP4, finalResultP5);
        }

        private static void PrintResultsOfP1P2P3P4P5(double finalResultP1, double finalResultP2, double finalResultP3, double finalResultP4, double finalResultP5)
        {
            string percent = "%";
            Console.WriteLine("p1 = {0:f2}{1}", finalResultP1, percent);
            Console.WriteLine("p2 = {0:f2}{1}", finalResultP2, percent);
            Console.WriteLine("p3 = {0:f2}{1}", finalResultP3, percent);
            Console.WriteLine("p4 = {0:f2}{1}", finalResultP4, percent);
            Console.WriteLine("p5 = {0:f2}{1}", finalResultP5, percent);
        }
    }
}
