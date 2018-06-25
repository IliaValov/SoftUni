using System;

namespace _01_Hello__Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(Hello(name));
        }
        static string Hello(string name)
        {
            string helloName = "Hello, "+name+"!";
            return helloName;
        }
    }
}
