using System;

namespace SquareofStars
{
    class SquareofStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char star = '*';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write(star);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }

        }
    }
}
