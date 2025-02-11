/*
3
0 1
0 right 1
2 right 1
end
 
10
[0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
0 5 9
[1, 0, 0, 0, 0, 1, 0, 0, 0, 1]
0 right 5
[0, 0, 0, 0, 0, 1, 0, 0, 0, 1]
0 right 5
[0, 0, 0, 0, 0, 1, 0, 0, 0, 1] 
5 left 2
[0, 0, 0, 1, 0, 0, 0, 0, 0, 1] 
9 right -7
[0, 0, 1, 1, 0, 0, 0, 0, 0, 1] 
end
"0 0 1 1 0 0 0 0 0 1"
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int fieldLength = int.Parse(Console.ReadLine());
        int[] bugPlaces = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] field = new int[fieldLength];

        for (int i = 0; i < bugPlaces.Length; i++)
        {
            int bugIndex = bugPlaces[i];
            if (bugIndex >= 0 && bugIndex <= field.Length - 1)
            {
                field[bugIndex] = 1;
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] arguments = command.Split();
            int bugIndex = int.Parse(arguments[0]);
            string direction = arguments[1];
            int distance = int.Parse(arguments[2]);

            if (bugIndex >= 0 && bugIndex <= field.Length - 1 && field[bugIndex] == 1)
            {
                field[bugIndex] = 0;
                int newPosition;
                if (direction == "right")
                {
                    newPosition = bugIndex + distance;
                    while (newPosition >= 0 && newPosition <= field.Length - 1 && field[newPosition] == 1)
                    {
                        newPosition += distance;
                    }

                    if (newPosition >= 0 && newPosition <= field.Length - 1)
                    {
                        field[newPosition] = 1;
                    }
                }
                else if (direction == "left")
                {
                    newPosition = bugIndex - distance;
                    while (newPosition >= 0 && newPosition <= field.Length - 1 && field[newPosition] == 1)
                    {
                        newPosition -= distance;
                    }

                    if (newPosition >= 0 && newPosition <= field.Length - 1)
                    {
                        field[newPosition] = 1;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}
