using System;

namespace AllNumberEndingToSeven
{
    class AllNumberEndingToSeven
    {
        static void Main()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i == 7 || i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
