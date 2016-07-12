using System;

namespace EvenPowerOfTwo
{
    class EvenPowerOfTwo
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 0; i <= number; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(sum);
                    sum *= 4;
                }

            }

        }
    }
}
