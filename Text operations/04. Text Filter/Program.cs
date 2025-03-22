string[] stringToBan = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
foreach (string word in stringToBan)
{
    text = text.Replace(word, new string('*', word.Length));
}
Console.WriteLine(text);