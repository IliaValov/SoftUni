using System;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;
                    if (i + j == magicalNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNum}");
                        return;
                    }
  
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
        }
    }
}
