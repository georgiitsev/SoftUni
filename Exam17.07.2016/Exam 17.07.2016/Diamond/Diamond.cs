using System;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int points = number;
            int stars = number * 3;
            int pointsInTheMiddle = stars;

            for (int i = 0; i < number; i++)
            {

                if (i == 0)
                {
                    Console.Write("{0}{1}{0}", new string('.', points), new string('*', stars));
                    points--;
                    Console.WriteLine();
                }
                Console.WriteLine("{0}*{1}*{0}", new string('.', points), new string('.', pointsInTheMiddle));
                points--;
                pointsInTheMiddle += 2;

            }
            Console.WriteLine("{0}", new string('*', number * 5));
            points = 1;
            pointsInTheMiddle = number * 5 - 4;

            for (int i = 0; i < number * 2 ; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', points), new string('.', pointsInTheMiddle));
                points++;
                pointsInTheMiddle -= 2;
               
            }
            Console.WriteLine("{0}{1}{0}", new string('.', number * 2 + 1), new string('*', number - 2));

        }
    }
}
