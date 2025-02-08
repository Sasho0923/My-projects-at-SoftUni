using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1) 
            {
                int[] condensed = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++) 
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);










            /*
               GoShow code for reference
               int[] numbers1 = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

            while (numbers1.Length > 1)
            {
                int[] condensedArray = new int[numbers1.Length - 1];

                for (int i = 0; i < numbers1.Length - 1; i++)
                {
                    condensedArray[i] = numbers1[i] + numbers1[i + 1];
                }

                numbers1 = condensedArray;
            }

            Console.WriteLine(numbers1[0]);
            */

        }
    }
}