using System.Text;

string[] strings = Console.ReadLine().Split();
StringBuilder result = new StringBuilder();
foreach (string word in strings)
{
    for (int i = 0; i < word.Length; i++)
    {
        result.Append(word);
    }
}
Console.WriteLine(result);