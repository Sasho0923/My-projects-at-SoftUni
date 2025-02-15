using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demos
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsTrue(number)) ;
        }

        static bool IsTrue(int number) 
        {
            bool isNumberPositive = false;
            if (number > 0)
            {
                isNumberPositive = true;
            }
            return isNumberPositive;
        }
    }
}
