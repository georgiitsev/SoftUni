using System;

namespace Diamond
{
    class Diamond
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int lineLeftRIght = (number - 2) / 2;
            int lineInside = (number - (lineLeftRIght * 2) - 2);

            if (number % 2 == 0)
            {
                // up SIde To Middle
                for (int i = 0; i < (number / 2) - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', lineLeftRIght), new string('-', lineInside));
                    lineLeftRIght--;
                    lineInside += 2;
                }
                //down
                for (int i = (number / 2); i > 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', lineLeftRIght), new string('-', lineInside));
                    lineLeftRIght++;
                    lineInside -= 2;
                }

            }
            else
            {
                int lineLeftRightOdd = (number - 1) / 2;//line and right "-" of diamond
                int secondLinerightOrLeftOdd = (number - 2) / 2;
                int lineInsideOdd = (number - (lineLeftRIght * 2) - 2);//"-" between stars in the middle of  figure
                //LoopForUpSIde
                for (int i = 0; i < (number / 2); i++)
                {
                    //Check And Print First Line With One Star
                    if (i == 0)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('-', lineLeftRightOdd), "*");
                        lineLeftRightOdd--;

                    }
                    //Print other lines to middle of diamond
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', lineLeftRightOdd), new string('-', lineInsideOdd));
                        lineLeftRightOdd--;
                      lineInsideOdd += 2;
                    }

                }
                //print down lines of diamond
                for (int i = (number / 2) ; i > 0; i--)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', lineLeftRightOdd), new string('-', lineInsideOdd));
                    lineLeftRightOdd++;
                    lineInsideOdd -= 2;
                }
                Console.WriteLine("{0}{1}{0}",new string('-',lineLeftRightOdd),"*");

            }
        }
    }
}
