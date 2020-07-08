using System;

namespace Exercici_Noms_Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////// FASE 1 ////////// 
            Console.WriteLine("_____Fase 1_____");

            Console.WriteLine("Insert 6 cities names");
            string city1 = Console.ReadLine();
            string city2 = Console.ReadLine();
            string city3 = Console.ReadLine();
            string city4 = Console.ReadLine();
            string city5 = Console.ReadLine();
            string city6 = Console.ReadLine();

            Console.WriteLine($"{city1}, {city2}, {city3}, {city4}, {city5}, {city6}");

            ////////// FASE 2 ////////// 
            Console.WriteLine("_____Fase 2_____");

            string[] cities = new string[6] { city1,city2,city3,city4,city5,city6 };

            Array.Sort(cities);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(cities[i]);
            }

            ////////// FASE 3 ////////// 
            Console.WriteLine("_____Fase 3_____");

            for (int i = 0; i < 6; i++)
            {
                string text = cities[i].Replace("a", "4");
                cities[i] = text;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(cities[i]);
            }
        }
    }
}
