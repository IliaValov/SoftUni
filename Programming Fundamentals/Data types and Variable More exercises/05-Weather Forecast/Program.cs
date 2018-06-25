using System;

namespace _05_Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string weather = "";

            
            
            
            try
            {
                float floating = float.Parse(number);
                weather = "Rainy";
            }
            catch
            {

            }
            try
            {
                long longg = long.Parse(number);
                weather = "Windy";
            }
            catch
            {

            }
            try
            {
                int integer = int.Parse(number);
                weather = "Cloudy";
            }
            catch
            {

            }
            try
            {
                sbyte ssbyte = sbyte.Parse(number);
                weather = "Sunny";

            }
            catch
            {


            }
            Console.WriteLine($"{weather}");
        }
    }
}
