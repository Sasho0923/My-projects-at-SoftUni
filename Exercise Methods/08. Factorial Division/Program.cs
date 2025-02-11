using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial_Division
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double finalResult = Factorial(num1) / Factorial(num2);
            Console.WriteLine($"{finalResult:F2}");

        }

        static double Factorial(int number)
        {
            double result = 1;

            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
