using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int hourOnExam = int.Parse(Console.ReadLine());
            int minutesOnExam = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minutesArrived = int.Parse(Console.ReadLine());
            string late = "Late";
            string onTime = "On time";
            string early = "Early";
            int allTimeInMinutesExam = (hourOnExam * 60) + minutesOnExam;
            int allTimeInMInutesStudent = (hourArrived * 60) + minutesArrived;
            //afterStartingExam
            if (allTimeInMinutesExam < allTimeInMInutesStudent)
            {
                int temporary = allTimeInMInutesStudent - allTimeInMinutesExam;

                if (temporary <= 30)
                {
                    Console.WriteLine(late);
                    Console.WriteLine("{0} minutes after the start", temporary);
                }
                if (temporary > 30 && temporary < 60)
                {
                    Console.WriteLine(late);
                    Console.WriteLine("{0} minutes after the start", temporary);
                }
                else if (temporary % 60 == 0)
                {
                    int h = temporary / 60;
                    int m = temporary % 60;
                    if (h == 0)
                    {
                        Console.WriteLine(late);
                        Console.WriteLine("{0}:{1}{1} minutes after the start", h, m);
                    }
                    else
                    {
                        Console.WriteLine(late);
                        Console.WriteLine("{0}:{1}{1} hours after the start", h, m);
                    }

                }
                else if (temporary > 60)
                {
                    int resultH = temporary / 60;
                    int resultM = temporary % 60;
                    Console.WriteLine(late);
                    if (resultM < 10)
                    {
                        Console.WriteLine(late);
                        Console.WriteLine("{0}:{2}{1} hours after the start", resultH, resultM, 0);
                    }
                    else
                    {
                        Console.WriteLine(late);
                        Console.WriteLine("{0}:{1} hours after the start", resultH, resultM);
                    }


                }

            }
            //beforeStartExam
            else if (allTimeInMinutesExam > allTimeInMInutesStudent)
            {
                int temporary = allTimeInMinutesExam - allTimeInMInutesStudent;
                if (temporary <= 30 && temporary >= 1)
                {
                    if (temporary <= 30)
                    {
                        Console.WriteLine(onTime);
                        Console.WriteLine("{0} minutes before the start", temporary);
                    }
                    else if (temporary % 60 == 0)
                    {
                        int h = temporary / 60;
                        int m = temporary % 60;
                        if (h == 0)
                        {
                            Console.WriteLine(early);
                            Console.WriteLine("{0}:{1}{1} minutes before the start", h, m);
                        }
                        else
                        {
                            if (m < 10)
                            {
                                Console.WriteLine(early);
                                Console.WriteLine("{0}:{2}{1} hours before the start", h, m, 0);
                            }

                        }
                    }

                }
                else if (temporary % 60 == 0)
                {
                    int h = temporary / 60;
                    int m = temporary % 60;
                    if (h == 0)
                    {
                        Console.WriteLine(early);
                        Console.WriteLine("{0}:{1}{1} minutes before the start", h, m);
                    }
                    else
                    {
                        Console.WriteLine(early);
                        Console.WriteLine("{0}:{1}{1} hours before the start", h, m);
                    }
                }
                else if (temporary > 30 && temporary < 60)
                {
                    Console.WriteLine(early);
                    Console.WriteLine("{0} minutes before the start", temporary);
                }
                else if (temporary > 60)
                {
                    int resultH = temporary / 60;
                    int resultM = temporary % 60;

                    if (resultM < 10)
                    {
                        Console.WriteLine(early);
                        Console.WriteLine("{0}:{2}{1} hours before the start", resultH, resultM, 0);
                    }
                    else
                    {
                        Console.WriteLine(early);
                        Console.WriteLine("{0}:{1} hours before the start", resultH, resultM);
                    }
                }
            }
            //On time
            else if (allTimeInMinutesExam == allTimeInMInutesStudent)
            {
                Console.WriteLine("On time");
            }

        }
    }
}
