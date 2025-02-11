﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main()
        {
            PrintCheckedNumber();
        }

        static void PrintCheckedNumber() 
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else 
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
