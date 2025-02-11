using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Palindrome_Integers
{
    internal class Program
    {
        static void Main()
        {
            string numberAsString = "";
            while ((numberAsString = Console.ReadLine()) != "END") 
            {
                bool isPalindrome = IsPalindrome(numberAsString);
                Console.WriteLine(isPalindrome);
            }
        }

        static bool IsPalindrome(string numberStr)
        {
            string reversedStr = Reversed(numberStr);

            if (reversedStr == numberStr) 
            {
                return true;
            }

            return false;
        }

        static string Reversed(string textforReverse)
        {
            char[] charArray = textforReverse.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            return reversed;
        }
    }
}
