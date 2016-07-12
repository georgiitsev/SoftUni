using System;

namespace SameWords
{
    class SameWords
    {
        static void Main()
        {
            string firstWord = Console.ReadLine().ToLower();
            string secondWord = Console.ReadLine().ToLower();

            if (firstWord.Contains(secondWord) || secondWord.Contains(firstWord))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
