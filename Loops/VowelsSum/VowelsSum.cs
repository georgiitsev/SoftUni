﻿using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= word.Length -1; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
