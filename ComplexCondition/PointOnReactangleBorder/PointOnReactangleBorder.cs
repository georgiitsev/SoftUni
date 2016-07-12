using System;

namespace PointOnReactangleBorder
{
    class Program
    {
        static void Main()
        {
            double rectangleX1 = double.Parse(Console.ReadLine());
            double rectangleY1 = double.Parse(Console.ReadLine());
            double rectangleX2 = double.Parse(Console.ReadLine());
            double rectangleY2 = double.Parse(Console.ReadLine());
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());


            if ((pointX > rectangleX1 && pointX < rectangleX2 && pointY > rectangleY1 && pointY < rectangleY2)
                || ((pointX < rectangleX1 || pointY < rectangleY1 || pointX > rectangleX2 || pointY > rectangleY2)))
            {
                Console.WriteLine("Inside / Outside");
            }
            else
            {
                Console.WriteLine("Border");
            }
        }
    }
}
