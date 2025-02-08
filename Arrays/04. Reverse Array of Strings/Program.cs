using System;
using System.Linq;

namespace _04.Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split()
                .ToArray();
            Array.Reverse(strings);
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
