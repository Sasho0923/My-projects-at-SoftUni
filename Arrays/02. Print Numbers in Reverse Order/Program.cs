using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                nums[i] = newNum;
            }
            for (int index = nums.Length - 1; index >= 0; index--)
            {
                Console.Write($"{nums[index]} ");
            }
        }
    }
}
