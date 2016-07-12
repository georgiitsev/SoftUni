using System;

namespace NumberFromOneToNMultiplyByTwo
{
    class NumberFromOneToNMultiplyByTwo
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            Console.WriteLine();
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(sum);
                sum *= 2;
            }

        }
    }
}
