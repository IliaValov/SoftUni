using System;

namespace _19_Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double percentOfTheGoodPhothos = int.Parse(Console.ReadLine());
            int neededTimeForFiltering = int.Parse(Console.ReadLine());

            
            double filteredPictures = Math.Ceiling(allPictures * (percentOfTheGoodPhothos / 100));
            int totalTimeForFiltering = (allPictures * filterTime) + (int)(filteredPictures * neededTimeForFiltering);

            int seconds = totalTimeForFiltering;
            int minutes = 0;
            int hours = 0;
            int days = 0;

            bool theTimeIsCalculated = true;
            while (theTimeIsCalculated)
            {
                if (minutes > 59)
                {
                    minutes -= 60;
                    hours++;
                }
                if (hours > 23)
                {
                    hours -= 24;
                    days++;
                }
                if (totalTimeForFiltering > 59)
                {
                    totalTimeForFiltering -= 60;
                    seconds -= 60;
                    minutes++;
                }
                else
                {
                    theTimeIsCalculated = false;
                }
            }
            

            
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
