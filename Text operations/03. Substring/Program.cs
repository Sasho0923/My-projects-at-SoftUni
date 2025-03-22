string substringToRemove = Console.ReadLine();
string fullString = Console.ReadLine();
while (fullString.Contains(substringToRemove))
{
    int index = fullString.IndexOf(substringToRemove);
    fullString = fullString.Remove(index, substringToRemove.Length);
}
Console.WriteLine(fullString);