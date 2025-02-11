using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
            Hey hello 2 4
            10 hey 4 hello
*/
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            for (int i = 0; i < arr2.Length; i++)
            {
                string currentStringArr2 = arr2[i];
                for (int j = 0; j < arr1.Length; j++)
                {
                    string currentStringArr1 = arr1[j];
                    if (currentStringArr2 == currentStringArr1)
                    {
                        Console.Write($"{arr1[j]} ");
                    }
                }
            }
        }
    }
}
