using System;

namespace _11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = int.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            float convertAllInHours = hours + (minutes / 60) + (seconds / 3600);
            float convertAllInMinutes = (hours * 60) + minutes + (seconds / 60);
            float convertAllInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            float kilometersInHours = (distance/1000) / (convertAllInMinutes/60);
            float metarsInSeconds = distance / convertAllInSeconds;
            float milesInHours = (distance / 1609) / (convertAllInMinutes/60);

            Console.WriteLine(metarsInSeconds);
            Console.WriteLine(kilometersInHours);
            Console.WriteLine(milesInHours);
        }
    }
}
