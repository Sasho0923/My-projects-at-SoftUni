/*
 Gold|Silver|Bronze|Medallion|Cup
 Loot Wood Gold Coins
 Loot Silver Pistol
 Drop 3
 Steal 3
 Yohoho!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Shoot_for_the_Win
{
    internal class Program
    {
        static void Main()
        {
            List<string> chest = Console.ReadLine()
                .Split('|')
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action) 
                {
                    case "Loot":
                        InsertLoot(tokens, chest);
                        break;
                    case "Drop":
                        Drop(int.Parse(tokens[1]), chest);
                        break;
                    case "Steal":
                        Steal(int.Parse(tokens[1]), chest);
                        break;
                }
            }

            double sum = 0;
            int itemsCount = 0;
            for (int i = 0; i < chest.Count; i++) 
            {
                sum += (chest[i]).Length;
                itemsCount++;
            }
            if (chest.Count != 0)
            {
                double averageGain = sum / itemsCount;
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else 
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }

        static void InsertLoot(string[] loot, List<string> chest) 
        {
            for (int i = 1; i < loot.Length; i++)
            {
                string item = loot[i];

                if (!chest.Contains(item)) 
                {
                    chest.Insert(0, item);
                }
            }
        }

        static void Drop(int index, List<string> chest) 
        {
            if (index > 0 && index < chest.Count) 
            {
                string item = chest[index];

                chest.RemoveAt(index);
                chest.Add(item);
            }
        }

        static void Steal(int count, List<string> chest) 
        {
            count = Math.Min(count, chest.Count);

            List<string> stolenItems = new List<string>();

            for (int i = 0; i < count; i++) 
            {
                string stolenItem = chest[chest.Count - 1];

                stolenItems.Insert(0, stolenItem);

                chest.RemoveAt(chest.Count - 1);
            }

            Console.WriteLine(string.Join(", ", stolenItems));
        }
    }
}
