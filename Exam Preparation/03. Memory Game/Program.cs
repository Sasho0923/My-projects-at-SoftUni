using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03.Memory_Game
{
    internal class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            int moves = 0;

            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
                moves++;

                int[] indexes = command
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int index1 = indexes[0];
                int index2 = indexes[1];

                if (!AreIndexesValid(index1, index2, elements.Count))
                {
                    SetPenaltyElements(moves, elements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[index1] == elements[index2])
                {
                    string matchingElement = elements[index1];
                    Console.WriteLine($"Congrats! You have found matching elements - {matchingElement}!");
                    if (index1 > index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    else 
                    {
                        elements.RemoveAt(index2);
                        elements.RemoveAt(index1);
                    }
                }
                else 
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0) 
                {
                    Console.WriteLine($"You have won in {moves} turns!");

                    return;
                }
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }

        static bool AreIndexesValid(int index1, int index2, int count) 
        {
            return
                index1 != index2 &&
                index1 >= 0 &&
                index1 < count &&
                index2 >= 0 &&
                index2 < count;
        }

        static void SetPenaltyElements(int moves, List<string> elements) 
        {
            string penaltyElements = $"-{moves}a";

            elements.Insert(elements.Count / 2, penaltyElements);
            elements.Insert(elements.Count / 2, penaltyElements);
        }
    }
}
