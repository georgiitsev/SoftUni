using System;

namespace AreaOfTriangle
{
    class AreaOfTriangle
    {

        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (side * h) / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
