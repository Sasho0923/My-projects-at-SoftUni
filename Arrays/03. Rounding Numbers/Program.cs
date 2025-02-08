using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                      .Split()
                                      .Select(double.Parse)
                                      .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int roundedNumber = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNumber}");
            }
        }
    }
}
