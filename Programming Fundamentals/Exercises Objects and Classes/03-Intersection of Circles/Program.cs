using System;
using System.Linq;

namespace _03_doubleersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] circle1Data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] circle2Data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double x1 = circle1Data[0];
            double y1 = circle1Data[1];
            double circleRadius1 = circle1Data[2];



            double x2 = circle2Data[0];
            double y2 = circle2Data[1];
            double circleRadius2 = circle2Data[2];



            double distance = Math.Pow(x2-x1,2) + Math.Pow(y2 - y1,2);

            if (circleRadius1 + circleRadius2 >= distance)
            {
                Console.WriteLine("Yes");

            }
            else if(circleRadius2 + circleRadius1 < distance)
            {
                Console.WriteLine("No");
            }
            

            
        }
    }
}
