﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j]) 
                    {
                        isTop = false;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
