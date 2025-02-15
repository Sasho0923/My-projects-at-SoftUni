/*
100
10
10
10
1
2
3
73
10
 */
using System;

namespace _01.Counter_Strike
{
    internal class Program
    {
        static void Main()
        {

            int energy = int.Parse(Console.ReadLine());
            int wins = 0;

            string command;

            while ((command = Console.ReadLine()) != "End of battle") 
            {
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");

                    return;
                }

                energy -= distance;
                wins++;

                if (wins % 3 == 0) 
                {
                    energy += wins;
                }
            }

            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
