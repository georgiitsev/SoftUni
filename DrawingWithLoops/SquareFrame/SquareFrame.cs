using System;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string minus ="-";
            string plus = "+";
            string line = "|";

            //TopPart
            Console.Write(plus);
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(" {0}",minus);
            }
            Console.WriteLine(" {0}", plus);

            //MiddlePArt
            for (int j = 0; j < number -2 ; j++)
            {
                Console.Write(line);
                for (int i = 0; i < number - 2; i++)
                {
                    Console.Write(" {0}", minus);
                }
                Console.WriteLine(" {0}", line);
   
            }
            
            //DownPart
            Console.Write(plus);
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write(" {0}", minus);
            }
            Console.WriteLine(" {0}", plus);

        }
    }
}
