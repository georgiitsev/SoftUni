using System;

namespace RombusOfStar
{
    class RombusOfStar
    {
        static void Main()
        {
            int sizeOfLoop = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sizeOfLoop; i++)
            {
                for (int j = 1; j <= sizeOfLoop - i; j++)
                {
                    Console.Write(" ");
                }
                for (int r = 1; r < i; r++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
            for (int i = sizeOfLoop -1; i >= 1; i--)
            {
                 for (int j = 1; j <= sizeOfLoop - i; j++)
                {
                    Console.Write(" ");
                }
                for (int r = 1; r < i; r++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
            

        }
    }
}
