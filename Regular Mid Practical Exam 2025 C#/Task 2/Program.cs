using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<string> coffees = Console.ReadLine()
                .Split()
                .ToList();

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();

                switch (command[0]) 
                {
                    case "Include":

                        Include(coffees, command);

                        break;
                    case "Remove":

                        Remove(coffees, command);

                        break;
                    case "Prefer":

                        Prefer(coffees, command);

                        break;
                    case "Reverse":

                        Reverse(coffees);

                        break;
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffees));
        }

        static void Include(List<string> coffees, string[] command) 
        {
            coffees.Add(command[1]);
        }

        //static void Remove(List<string> coffees, string[] command)
        //{
        //    for (int i = 0; i < int.Parse(command[2]); i++) 
        //    {
        //        if (i >= 1)
        //        {
        //            i--;
        //            if (command[1] == "first")
        //            {
        //                coffees.Remove(coffees[i]);
        //            }
        //            else if (command[1] == "last")
        //            {
        //                coffees.Remove(coffees[coffees.Count - i]);
        //            }
        //            i++;
        //        }
        //        else 
        //        {
        //            if (command[1] == "first")
        //            {
        //                coffees.Remove(coffees[i]);
        //            }
        //            else if (command[1] == "last")
        //            {
        //                coffees.Remove(coffees[coffees.Count - i]);
        //            }
        //        }
        //    }
        //}

        static void Remove(List<string> coffees, string[] command)
        {
            int count = int.Parse(command[2]);

            if (count > coffees.Count)
            {
                return;
            }

            if (command[1] == "first")
            {
                coffees.RemoveRange(0, count);
            }
            else if (command[1] == "last")
            {
                coffees.RemoveRange(coffees.Count - count, count);
            }
        }

        static void Prefer(List<string> coffees, string[] command)
        {
            int index1 = int.Parse(command[1]);
            int index2 = int.Parse(command[2]);

            if (index1 >= 0 && index1 < coffees.Count && index2 >= 0 && index2 < coffees.Count)
            {
                (coffees[index1], coffees[index2]) = (coffees[index2], coffees[index1]);
            }
        }

        static void Reverse(List<string> coffees)
        {
            coffees.Reverse();
        }
    }
}
