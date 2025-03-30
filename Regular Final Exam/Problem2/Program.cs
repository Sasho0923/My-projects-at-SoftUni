using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string pattern = @"^(?<symbols>[ -~]+)>(?<digits>\d{3})\|(?<lowercase>[a-z]{3})\|(?<uppercase>[A-Z]{3})\|(?<special>[^<>|]{3})<\k<symbols>$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    // Extracting groups
                    string encryptedPassword = match.Groups["digits"].Value +
                                               match.Groups["lowercase"].Value +
                                               match.Groups["uppercase"].Value +
                                               match.Groups["special"].Value;

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}