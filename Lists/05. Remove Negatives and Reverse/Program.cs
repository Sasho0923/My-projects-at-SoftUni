using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //for (int i = 0; i < numbers.Count; i++) 
            //{
            //    if (numbers[i] < 0) 
            //    {
            //        numbers.Remove(i);
            //        i--;
            //    }
            //}

            numbers.RemoveAll(number => number < 0);

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else 
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
