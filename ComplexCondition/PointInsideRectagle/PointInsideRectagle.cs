using System;

namespace PointInsideRectagle
{
    class PointInsideRectagle
    {
        static void Main()
        {
            double rectangleX1 = double.Parse(Console.ReadLine());
            double rectangleX2 = double.Parse(Console.ReadLine());
            double rectangleY1 = double.Parse(Console.ReadLine());
            double rectangleY2 = double.Parse(Console.ReadLine());
            double rectangleX = double.Parse(Console.ReadLine());
            double rectangleX = double.Parse(Console.ReadLine());

            if (pointX >= rectangleX1 && pointX <= rectangleX2 && pointY >= rectangleY1 && pointY <= rectangleY2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
