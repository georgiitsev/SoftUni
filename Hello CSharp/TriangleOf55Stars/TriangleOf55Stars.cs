using System;

namespace TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main(string[] args)
        {
            string stars = "*";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stars);
                stars = stars + "*";
            }
        }
    }
}
