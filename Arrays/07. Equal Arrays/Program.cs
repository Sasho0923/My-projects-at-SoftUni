using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNums1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrOfNums2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int index;
            for (index = 0; index < arrOfNums1.Length; index++) 
            {
                if (arrOfNums1[index] != arrOfNums2[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    break;
                }
                if (arrOfNums1[index] == arrOfNums2[index])
                {
                    int currentNumOfArr1 = arrOfNums1[index];
                    sum += currentNumOfArr1;
                }
            }
            if (index>=arrOfNums1.Length) 
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
