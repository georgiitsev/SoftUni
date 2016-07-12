using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int scores = int.Parse(Console.ReadLine());
            double score = double.Parse(scores.ToString());
            double result;
            double temp;
            if (score <= 100)
            {
                if (score % 2 == 0)
                {
                    result = score + 6;
                    Console.WriteLine(6);
                    Console.WriteLine(result);

                }
                
                else if (score % 5 == 0)
                {

                    if (score % 10 == 5)
                    {
                        result = score + 7;
                        Console.WriteLine(7);
                        Console.WriteLine(result);
                        if (score == 5)
                        {
                            result = score + 7;
                            Console.WriteLine(7);
                            Console.WriteLine(result);
                        }
                    }


                }
                else
                {
                    result = score + 5;
                    Console.WriteLine(5);
                    Console.WriteLine(result);
                }

            }
            if (score > 100 && score <= 1000)
            {

                if (score % 2 == 0)
                {
                    result = score / 5;
                    Console.WriteLine(result + 1);
                    temp = score + result;
                    result = temp + 1;
                    Console.WriteLine(result);
                }
                else
                {
                    if (score % 10 == 5)
                    {
                        result = score / 5;
                        Console.WriteLine(result + 2);
                        temp = result + score;
                        result = temp + 2;
                        Console.WriteLine(result);


                    }
                    else
                    {
                        result = score / 5;
                        Console.WriteLine(result);
                        temp = result + score;
                        result = temp;
                        Console.WriteLine(result);
                    }

                }

            }
            if (score > 1000)
            {
                if (score % 2 == 0)
                {
                    result = score / 10;
                    Console.WriteLine(result + 1);
                    temp = result + score;
                    result = temp + 1;
                    Console.WriteLine(result);

                }
                else
                {
                    if (score % 5 == 0)
                    {

                        if (score % 10 == 5)
                        {
                            result = score / 10;
                            Console.WriteLine(result + 2);
                            temp = result + score;
                            result = temp + 2;
                            Console.WriteLine(result);
                        }


                    }
                    else
                    {
                        result = score / 10;
                        Console.WriteLine(result);
                        temp = result + score;
                        result = temp;
                        Console.WriteLine(result);

                    }
                }

            }
        }
    }
}