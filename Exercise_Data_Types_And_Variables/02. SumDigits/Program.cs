using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int sum = 0;
            
            do 
            {
                currentNum = integer%10;
                integer /= 10;
                sum += currentNum;
            } while (integer > 0);
            Console.WriteLine(sum);
        }
    }
}
