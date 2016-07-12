using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sumOfAllNumbers = 0;
            int result = 0;

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int numbersForSum = int.Parse(Console.ReadLine());
                sumOfAllNumbers += numbersForSum;

                if (numbersForSum > maxNumber)
                {
                    maxNumber = numbersForSum;
                }
            }
            result = sumOfAllNumbers - maxNumber;
            sumOfAllNumbers =Math.Abs(maxNumber - result);
            if (result == maxNumber)
            {
                Console.WriteLine("Yes, Sum = {0}", maxNumber);
            }
            else
            {
                
                Console.WriteLine("No, Diff = {0}", sumOfAllNumbers);
            }

        }
    }
}
