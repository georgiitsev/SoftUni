using System;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        for (int m = 0; m < l; m++)
                        {
                            for (int p = 1; p <= n; p++)
                            {
                                if (p > i && p > j)
                                {
                                    string result = i.ToString() + j + (char)(k + 97) + (char)(m + 97) + p;
                                    Console.Write(result + " ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
