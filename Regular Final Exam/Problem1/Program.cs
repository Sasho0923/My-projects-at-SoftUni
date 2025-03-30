/*
Enroll Stefan
Enroll Peter
Enroll Stefan
Learn Stefan ItShouldWork
Learn John ItShouldNotWork
Unlearn George Dispel
Unlearn Stefan ItShouldWork
End
*/

using System.Collections.Generic;
using System;
using System.Linq;

namespace Problem_3
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                List<string> spells = new();
                string[] commandTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = commandTokens[1];
                switch (commandTokens[0])
                {
                    case "Enroll":

                        if (!heroes.ContainsKey(heroName))
                        {
                            heroes.Add(heroName, spells);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;

                    case "Learn":
                        string spell = commandTokens[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (!heroes[heroName].Contains(spell))
                            {
                                heroes[heroName].Add(spell);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} has already learnt {spell}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }

                        break;

                    case "Unlearn":
                        spell = commandTokens[2];
                        if (heroes.ContainsKey(heroName))
                        {
                            if (heroes[heroName].Contains(spell))
                            {
                                heroes[heroName].Remove(spell);
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} doesn't know {spell}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        break;
                }
            }
            string output = string.Empty;
            foreach ((string heroName, List<string> spells) in heroes)
            {
                output += $"== {heroName}: {string.Join(", ", spells)}\n";
            }
            Console.WriteLine($"Heroes:");
            Console.WriteLine(output);
        }
    }
}