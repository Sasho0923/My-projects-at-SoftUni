﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(width, height);

            Console.WriteLine(rectangleArea);
        }

        static double CalculateRectangleArea(double width, double height) 
        {
            return width * height;
        }

    }
}
