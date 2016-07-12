using System;

namespace _2DRectangleArea
{
    class TwoDimentionRectangleArea

    {
        static void Main()
        {
            Console.WriteLine("Enter x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            double y2 = double.Parse(Console.ReadLine());
            double sideARectangle;
            double sideBRectangle;
            if (x1>x2)
            {
                 sideARectangle = x1 - x2;  
            }
            else
            {
                sideARectangle = x2 - x1;  
            }
            if (y1>y2)
            {
                 sideBRectangle = y1 - y2;  
            }
            else
            {
                 sideBRectangle = y2 - y1;
            }
            double areaRectangle = sideARectangle * sideBRectangle;
            double perimeterRectangle = (2*(sideARectangle+sideBRectangle));
            Console.WriteLine(areaRectangle);
            Console.WriteLine(perimeterRectangle);
        }
    }
}
