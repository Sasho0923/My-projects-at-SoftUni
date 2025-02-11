using System;

namespace _10.Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            PrintTopNumbers(endValue);
        }

        static void PrintTopNumbers(int endValue)
        {
            for (int i = 1; i <= endValue; i++) // Fixed: include `endValue`
            {
                if (IsDigitsSumDivisibleBy8(i) && ContainsAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDigitsSumDivisibleBy8(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp > 0) // Correct way to extract digits
            {
                sum += temp % 10; // Add last digit to sum
                temp /= 10;       // Remove last digit
            }

            return sum % 8 == 0;
        }

        static bool ContainsAtLeastOneOddDigit(int number)
        {
            int temp = number;

            while (temp > 0) // Correct way to extract digits
            {
                int digit = temp % 10;

                if (digit % 2 != 0) // Check if odd
                {
                    return true;
                }

                temp /= 10; // Remove last digit
            }

            return false;
        }
    }
}