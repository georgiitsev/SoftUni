using System;

namespace DrawingFort
{
    class DrawingFort
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int exsorWithLIneLikeComment = number / 2;
            int line = (number * 2) - (exsorWithLIneLikeComment * 2 + 4);
            int emptySpaces = (number * 2) - 2;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', exsorWithLIneLikeComment), new string('_', line));
            if (number >= 3 && number <= 4)
            {
                for (int i = 0; i < number - 2; i++)
                {
                    Console.WriteLine("{0}{1}{0}", "|", new string(' ', (number * 2) - 2));
                }
                Console.WriteLine("\\{0}/\\{0}/",new string ('_',exsorWithLIneLikeComment));
            }
            else
            {
                for (int i = 0; i < number - 3; i++)
                {
                    Console.WriteLine("{0}{1}{0}", "|", new string(' ', emptySpaces));
                    if (i == number - 4)
                    {
                        Console.WriteLine("|{0}{1}{0}|", new string(' ', exsorWithLIneLikeComment + 1), new string('_', line));
                        Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', exsorWithLIneLikeComment), new string(' ', line));
                        break;
                    }
            }
            

            }
        }
    }
}
