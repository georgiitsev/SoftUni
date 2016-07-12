using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int rotation = number ;
            for (int i = 0; i < rotation ; i++)
            {
                Console.Write("*");
                for (int j = 0; j < number-1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        

        }
    }
}
