using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;
            if (input < 0)
            {
                input = Math.Abs(input);
            }

            Console.WriteLine(GetMultipleOfEvenAndOdds(input, sumOfEvenDigits, sumOfOddDigits));

        }
        static int GetSumOfEvenDigits(int input, int sumOfEvenDigits) 
        {
            for (int i = input; i >= 0; i--) 
            {
                int currentNum = input % 10;
                if (currentNum % 2 == 0) 
                {
                    sumOfEvenDigits += currentNum;
                }
                input /= 10;
            }
            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(int input, int sumOfOddDigits)
        {
            for (int i = input; i >= 0; i--)
            {
                int currentNum = input % 10;
                if (currentNum % 2 != 0)
                {
                    sumOfOddDigits += currentNum;
                }
                input /= 10;
            }
            return sumOfOddDigits;
        }

        static int GetMultipleOfEvenAndOdds(int input, int sumOfEvenDigits, int sumOfOddDigits)
        {
            int mult = GetSumOfEvenDigits(input, sumOfEvenDigits) * GetSumOfOddDigits(input, sumOfOddDigits);
            return mult;
        }
    }
}
