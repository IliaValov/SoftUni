using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> authorAndPricePerBook = 
                new Dictionary<string, DateTime>();

        
            double n = double.Parse(Console.ReadLine());
            

            for (double i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                
                

                }
                DateTime date = DateTime.ParseExact(line[4], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                if (!authorAndPricePerBook.ContainsKey(line[1]))
                {
                    authorAndPricePerBook.Add(line[1], date);                   
                }
                else if (authorAndPricePerBook.ContainsKey(line[1]))
                {
                    
                }
            }

            foreach (var author in authorAndPricePerBook.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
}
