/*
4
1 5
9 10
31 81
41 20
 */







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr1 = new int[lines];
            int[] arr2 = new int[lines];
            for (int i = 0; i < lines; i++)
            {
                int[] currentNums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = currentNums[i];
                    arr2[i] = currentNums[i + 1];
                }
                else 
                {
                    arr1[i] = currentNums[i + 1];
                    arr2[i] = currentNums[i];
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
        }
    }
}
