using System;

namespace NumberInRangeOneToOneHundred
{
    class NumberInRangeOneToOneHundred
    {
        static void Main()
        {
            for (int i = 0;;)
            {
                Console.Write("Еnter a number in the range [1...100]: ");
                int numberInRange1To100 = int.Parse(Console.ReadLine());

                if (numberInRange1To100 > 0 && numberInRange1To100 <= 100)
                {
                    Console.WriteLine("The number is: {0}",numberInRange1To100);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
