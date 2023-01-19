using System;

namespace AnimalsControl
{
    class program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            Console.WriteLine("Enter 5 animals's name (Only dog, cat or fish)");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i+1} Animal name: ");
                animal.Name[i] = Console.ReadLine();
                Console.Write("Type: ");
                animal.Type[i] = Console.ReadLine();
                Console.WriteLine();
            }
            animal.Counter();
            animal.show();
        }
    }
}