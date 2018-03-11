using System;

// Индексаторы.

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга", "rus"]);
            Console.WriteLine(dictionary["дом", "rus"]);
            Console.WriteLine(dictionary["ручка", "rus"]);
            Console.WriteLine(dictionary["стол", "rus"]);
            Console.WriteLine(dictionary["карандаш", "rus"]);
            Console.WriteLine(dictionary["яблоко", "rus"]);
            Console.WriteLine(dictionary["солнце", "rus"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
