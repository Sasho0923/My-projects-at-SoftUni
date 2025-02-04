using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = short.Parse(Console.ReadLine());
            int totalSum = 0;
            do 
            {
                char a = char.Parse(Console.ReadLine());
                totalSum += (int)a;
                lines--;
            }
            while (lines > 0);
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
