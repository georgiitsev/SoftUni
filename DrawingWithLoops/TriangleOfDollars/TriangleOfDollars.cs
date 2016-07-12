using System;

namespace TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main()
        {
            int numberOfRotation = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRotation; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("$ ");
                    
                }
                Console.WriteLine(" ");
            }

        }
    }
}
