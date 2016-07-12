using System;

namespace DrawingWithLoops
{
    class DrawRectangleOfTenStars
    {
        static void Main()
        {
            string stars = new string('*', 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stars);
            }
        }
    }
}
