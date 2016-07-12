using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int numberForSum = int.Parse(Console.ReadLine());
                sum += numberForSum;
            }
            Console.WriteLine(sum);
        }
    }
}
