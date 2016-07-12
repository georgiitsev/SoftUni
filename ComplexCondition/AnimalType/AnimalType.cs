using System;

namespace AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string animalKind = Console.ReadLine();

            switch (animalKind)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
