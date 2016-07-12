using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Perimeter = {0}",perimeter);
        }
    }
}
