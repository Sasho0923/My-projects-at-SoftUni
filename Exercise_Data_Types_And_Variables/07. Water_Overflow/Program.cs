using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            int maxLitres = byte.MaxValue;
            int totalLitres = 0;

            for (int i = 0; i < inputLines; i++) 
            { 
                int currentLitres = int.Parse(Console.ReadLine());

                if (totalLitres + currentLitres > maxLitres)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else 
                {
                    totalLitres += currentLitres;
                }
            }

            Console.WriteLine(totalLitres);
        }
    }
}
