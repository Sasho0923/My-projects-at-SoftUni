using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            if (char2 < char1)
            {
                char swap = char1;
                char1 = char2;
                char2 = swap;
            }

            PrintCharsInBetween(char1, char2);
        }

        private static void PrintCharsInBetween(char char1, char char2)
        {
            for (int i = char1 + 1; i < char2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
