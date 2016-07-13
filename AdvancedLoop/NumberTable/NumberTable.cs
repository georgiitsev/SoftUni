using System;

namespace NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());
           

            for (int row = 0; row < rotation; row++)
            {
                for (int cow = 0; cow < rotation; cow++)
                {
                    int num = row + cow + 1;

                    if (num > rotation)
                    {
                        num = 2 * rotation - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
