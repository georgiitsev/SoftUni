using System;

namespace NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            int rotation = int.Parse(Console.ReadLine());
            int num = 0;

            for (int row = 0; row < rotation; row++)
            {
                for (int cow = 0; cow < rotation; cow++)
                {

                    if (num <= rotation)
                    {
                        if (num == rotation)
                        {
                            num--;
                            Console.Write(num);
                        }
                        else
                        {
                            num = row + cow + 1;
                            Console.Write(num);
                        }
                    }
                    else
                    {
                        num = rotation * 2 - num; ;

                        Console.Write(num);
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
