using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main()
        {
            int lenghtofLoop = int.Parse(Console.ReadLine());
            double sumOdd = 0.00;
            double sumEven = 0.00;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;

            for (int i = 1; i <= lenghtofLoop; i++)
            {
                double controlNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += controlNumber;
                    if (controlNumber > maxEven)
                    {
                        maxEven = controlNumber;
                    }
                    if (controlNumber < minEven)
                    {
                        minEven = controlNumber;
                    }

                }
                else
                {
                    sumOdd += controlNumber;
                    if (controlNumber > maxOdd)
                    {
                        maxOdd = controlNumber;
                    }
                    if (controlNumber < minOdd)
                    {
                        minOdd = controlNumber;
                    }
                }
            }
            if (lenghtofLoop == 0)
            {
                sumOdd = 0;
                Console.WriteLine("OddSum = {0},",sumOdd);
                Console.WriteLine("OddMin = No,");
                Console.WriteLine("OddMax = No,");
                sumEven = 0;
                Console.WriteLine("EvenSum = {0},", sumEven);
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No,");
            }
            if (lenghtofLoop == 1)
            {
                Console.WriteLine("OddSum = {0},", sumOdd);
                Console.WriteLine("OddMin = {0},",minOdd);
                Console.WriteLine("OddMax = {0},",maxOdd);
                sumEven = 0;
                Console.WriteLine("EvenSum = {0},", sumEven);
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No,");
                
            }
            else
            {
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},", sumOdd, minOdd, maxOdd);
                Console.WriteLine("EvenSum={0},\nEvenMin={1},\nEvenMax={2},", sumEven, minEven, maxEven);
            }
           
        }
    }
}
