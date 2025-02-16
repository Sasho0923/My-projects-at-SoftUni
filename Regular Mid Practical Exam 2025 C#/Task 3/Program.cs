using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            int[] items = Console.ReadLine()
                .Split(', ')
                .Select(int.Parse)
                .ToArray();
        }
    }
}
