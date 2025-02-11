using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(Pow(baseNumber, power));
        }

        static double Pow(double baseNumber, int power) 
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
