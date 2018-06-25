using System;

namespace _02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events =  { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random random = new Random();


            for (int i = 0; i < repeat; i++)
            {
                int phrasesIndex = random.Next(0,phrases.Length-1);
                int eventsIndex = random.Next(0,events.Length-1);
                int authorsIndex = random.Next(0,authors.Length-1);
                int citiesIndex = random.Next(0,cities.Length-1);

                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} – {cities[citiesIndex]}");
            }

        }
    }
}
