/*


3 5 2 43 12 3 54 10 23
76 5 34 2 4 12

*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            int MaxlCount = list1.Count > list2.Count
                ? list1.Count 
                : list2.Count;
            for (int i = 0; i < MaxlCount; i++)
            {
                if (list1.Count>i)
                {
                    resultList.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    resultList.Add(list2[i]);
                }
            }
            

            Console.WriteLine(string.Join((" "), resultList));
        }
    }
}
