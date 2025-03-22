string command;
while ((command = Console.ReadLine()) != "end")
{
    char[] reversed = command.Reverse().ToArray();
    Console.WriteLine($"{command} = {string.Join("", reversed)}");
}