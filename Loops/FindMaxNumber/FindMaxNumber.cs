using System;

namespace FindMaxNumber
{
    class FindMaxNumber
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < sizeOfLoop; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                
            }

            Console.WriteLine(maxNumber);
        }
    }
}
