using System;

namespace Exam_17._07._2016
{
    class Money
    {
        static void Main()
        {
            const double uanToDollaers = 0.15;
            const double DollarsToBgn = 1.76;
            const double BgnToEur = 1.95;
            const int bitCoinceToBgn = 1168;

            int bitcoince = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            int middleResult = bitcoince * bitCoinceToBgn;
            
            double second = uan * uanToDollaers;
            second = second * DollarsToBgn;
            double final = (middleResult + second)/BgnToEur;
            double result = (final * comision) / 100;
            Console.WriteLine(final - result);


        }
    }
}
