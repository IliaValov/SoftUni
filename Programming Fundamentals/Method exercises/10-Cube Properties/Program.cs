using System;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            switch (type)
            {
                case "face":
                    Console.WriteLine($"{CubeFaceDig(side):F2}");
                    break;
                case "space":  
                    Console.WriteLine($"{CubeSpaceDig(side):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{CubeVolume(side):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{CubeSurArea(side):F2}");
                    break;
            }
        }
        static double CubeFaceDig(double number)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(number, 2));
            return faceDiagonal;
        }
        static double CubeSurArea(double number)
        {
            double surfaceArea = 6 * Math.Pow(number,2);
            return surfaceArea;
        }
        static double CubeSpaceDig(double number)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(number, 2));
            return spaceDiagonal;
        }
        static double CubeVolume(double number)
        {
            double volume = (double)Math.Pow(number, 3);
            return volume;
        }
    }
}
