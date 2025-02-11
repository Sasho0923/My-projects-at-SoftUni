using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i <= height; i++) 
            {
                PrintLine(1, i);
            }
            for (int i = height - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end) 
        {

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
