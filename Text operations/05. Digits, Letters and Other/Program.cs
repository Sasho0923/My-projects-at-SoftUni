﻿string text = Console.ReadLine();
string digits = string.Empty;
string letters = string.Empty;
string other = string.Empty;
foreach (char symbol in text)
{
    if (char.IsDigit(symbol))
    {
        digits += symbol;
    }
    else if (char.IsLetter(symbol))
    {
        letters += symbol;
    }
    else
    {
        other += symbol;
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(other);