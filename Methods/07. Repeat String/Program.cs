using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Repeat_String
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnStringTimes(word, times));

        }

        static string ReturnStringTimes(string word, int times) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(word);
            }
            return result.ToString();
        }
    }
}
