using System;

namespace FindMinNumber
{
    class FindMinNumber
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }

            }

            Console.WriteLine(minNumber);
        }
    }
}
