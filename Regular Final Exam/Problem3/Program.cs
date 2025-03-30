namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandTokens = command.Split(" ");

                switch (commandTokens[0])
                {
                    case "Replace":
                        input = Replace(input, commandTokens);
                        break;

                    case "Cut":
                        input = Cut(input, commandTokens);
                        break;

                    case "Make":
                        input = Make(input, commandTokens);
                        break;

                    case "Check":
                        Check(input, commandTokens);
                        break;

                    case "Sum":
                        Sum(input, commandTokens);
                        break;

                }
            }
        }

        private static void Sum(string input, string[] commandTokens)
        {
            int startIndex = int.Parse(commandTokens[1]);
            int endIndex = int.Parse(commandTokens[2]);

            if (startIndex >= 0 && endIndex < input.Length && startIndex <= endIndex)
            {
                string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                int sum = 0;

                foreach (char ch in substring)
                {
                    sum += (int)ch;
                }

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }
        }

        private static void Check(string input, string[] commandTokens)
        {
            string checkString = commandTokens[1];

            if (input.Contains(checkString))
            {
                Console.WriteLine($"Message contains {checkString}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {checkString}");
            }
        }

        private static string Make(string input, string[] commandTokens)
        {
            string casingType = commandTokens[1];

            if (casingType == "Upper")
            {
                input = input.ToUpper();
            }
            else if (casingType == "Lower")
            {
                input = input.ToLower();
            }

            Console.WriteLine(input);
            return input;
        }

        private static string Cut(string input, string[] commandTokens)
        {
            int startIndex = int.Parse(commandTokens[1]);
            int endIndex = int.Parse(commandTokens[2]);

            if (startIndex >= 0 && endIndex < input.Length && startIndex <= endIndex)
            {
                input = input.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }

            return input;
        }

        private static string Replace(string input, string[] commandTokens)
        {
            string charToReplace = commandTokens[1];
            string replacedChar = commandTokens[2];

            input = input.Replace(charToReplace, replacedChar);
            Console.WriteLine(input);
            return input;
        }
    }
}