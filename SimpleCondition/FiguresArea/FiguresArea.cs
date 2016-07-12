using System;

namespace FiguresArea
{
    class FiguresArea
    {
        static void Main()
        {
            Console.WriteLine("Tell me figure");
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    Console.WriteLine("Enter size of square side : ");
                    double side = double.Parse(Console.ReadLine());
                    double result = side * side;
                    Console.WriteLine("{0}", Math.Round(result, 3));
                    break;
                case "rectangle":
                    Console.WriteLine("Enter size of rectangle for firstside : ");
                    double firstSize = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter size of rectangle for firstside : ");
                    double secondSize = double.Parse(Console.ReadLine());
                    result = firstSize * secondSize;
                    Console.WriteLine("{0}",Math.Round(result,3));
                    break;
                case "circle":
                    Console.WriteLine("Please tell me R");
                    double rad = double.Parse(Console.ReadLine());
                    result = Math.PI * rad * rad;
                    Console.WriteLine("{0}", Math.Round(result, 3));
                    break;
                case "triangle":
                    double sideOfTriangle = double.Parse(Console.ReadLine());
                    double hOfTriangle = double.Parse(Console.ReadLine());
                    result = (sideOfTriangle * hOfTriangle) / 2;
                    Console.WriteLine("{0}", Math.Round(result, 3));
                    break;
                default:
                    Console.WriteLine("Wrong Entry");
                    break;
            }
        }
    }
}
