using System;

namespace EvenOrOddSum
{
    class EvenOrOddSum
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
           

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            int diff = Math.Abs(evenSum - oddSum);
            if (diff == 0)
            {
                Console.WriteLine("Yes sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No diff = {0}", diff);
            }
        }
    }
}
