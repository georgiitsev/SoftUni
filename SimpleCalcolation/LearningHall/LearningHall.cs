using System;

namespace LearningHall
{
    class LearningHall
    {
        static void Main()
        {
            double corridorWidth = 1.0;
            double deskHeight = 1.2;
            double deskWidth = 0.7;
            double desksPerRow;
            double desksPerColumn;


            Console.Write("Give height ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Give width ");
            double width = double.Parse(Console.ReadLine());

            if (!(3.0 <= height) || !(height >= width) || !(width <= 100.0))
            {
                return;
            }

            desksPerRow = Math.Floor((width - corridorWidth) / deskWidth);
            desksPerColumn = Math.Floor(height / deskHeight);
            Console.WriteLine(desksPerRow * desksPerColumn - 3);
        }
    }
}
