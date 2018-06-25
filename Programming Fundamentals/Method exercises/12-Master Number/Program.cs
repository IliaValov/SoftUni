using System;

namespace _12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int num)
        {
            string valueAsStr = num.ToString();
            bool isValid = true;

            for (int i  = 0; i < valueAsStr.Length/2; i ++)
            {
                if (valueAsStr[i] != valueAsStr[valueAsStr.Length - i - 1])
                {
                    isValid = false;
                    break;
                }
                
            }
            return isValid;
        }
        static bool SumOfDigits(int num)
        {
            bool isValid = false;
            int lastDigit = 0;
            int sum = 0;

            while(num > 0)
            {
                lastDigit = num % 10;
                num = num / 10;
                sum += lastDigit;
            }
            if (sum % 7 == 0)
            {
                isValid = true;
            }
            return isValid;
        }
        static bool ContainsEvenDigit(int num)
        {
            bool isValid = false;
            int n = num;
            int lastDigit = 0;
            while(n > 0)
            {
                lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    isValid = true;
                }
                n /= 10;
            }
            return isValid;


        }
    }
}
