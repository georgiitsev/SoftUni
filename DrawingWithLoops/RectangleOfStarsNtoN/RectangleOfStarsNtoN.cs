using System;

namespace RectangleOfStarsNtoN
{
    class RectangleOfStarsNtoN
    {
        static void Main()
        {
            int numberOfStarsOnLine = int.Parse(Console.ReadLine());
            string stars = new string('*', numberOfStarsOnLine);

            for (int i = 0; i < numberOfStarsOnLine; i++)
            {
                Console.WriteLine(stars);
            }
        }
    }
}
