using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_of_Products
{
    internal class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < numberOfProducts; i++) 
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
