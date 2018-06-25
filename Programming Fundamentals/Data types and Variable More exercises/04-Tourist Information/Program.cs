using System;

namespace _04_Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string type2 = "";
            float value = float.Parse(Console.ReadLine());
            float totalSum = 0;


            switch (type)
            {
                case "miles":
                    totalSum = value * 1.6f;
                    type2 = "kilometers";
                    break;
                case "inches":
                    totalSum = value * 2.54f;
                    type2 = "centimeters";
                    break;
                case "feet":
                    totalSum = value * 30;
                    type2 = "centimeters";
                    break;
                case "yards":
                    totalSum = value * 0.91f;
                    type2 = "meters";
                    break;
                case "gallons":
                    totalSum = value * 3.8f;
                    type2 = "liters";
                    break;
            }
            Console.WriteLine($"{type} {value} = {totalSum:F2} {type2}");
        }
    }
}