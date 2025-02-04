using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            do
            {
                char currentChar = (char)firstChar;
                firstChar ++;
                Console.Write($"{currentChar} ");
            } while ( firstChar <= lastChar );
        }
    }
}
