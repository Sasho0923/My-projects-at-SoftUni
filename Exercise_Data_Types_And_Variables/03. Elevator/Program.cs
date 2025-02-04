using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            int cap = int.Parse(Console.ReadLine());
            int fullCourses = ppl / cap;
            int additionalCourses = ppl % cap;
            if (additionalCourses != 0) 
            {
                fullCourses = fullCourses + 1;
            }
            Console.WriteLine(fullCourses);
        }
    }
}
