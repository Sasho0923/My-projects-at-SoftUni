//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04.Password_Validator
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string password = Console.ReadLine();

//            //if (CharCountChecker(password) == true)
//            //{
//            //    if (LettersAndDigitsChecker(password) == true)
//            //    {
//            //        if (DigitsInPassChecker(password) == true)
//            //        {
//            //            Console.WriteLine("Password is valid");
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine("Password must have at least 2 digits");
//            //        }
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Password must consist only of letters and digits");

//            //    }
//            //}
//            //else 
//            //{
//            //    Console.WriteLine("Password must be between 6 and 10 characters");
//            //}


//            bool isValid = true;

//            if (!CharCountChecker(password))
//            {
//                Console.WriteLine("Password must be between 6 and 10 characters");
//                isValid = false;
//            }
//            if (!LettersAndDigitsChecker(password))
//            {
//                Console.WriteLine("Password must consist only of letters and digits");
//                isValid = false;
//            }
//            if (!DigitsInPassChecker(password))
//            {
//                Console.WriteLine("Password must have at least 2 digits");
//                isValid = false;
//            }

//            if (isValid)
//            {
//                Console.WriteLine("Password is valid");
//            }
//        }

//        static bool CharCountChecker(string password)
//        {
//            int initialCount = password.Length;
//            int counter = 0;
//            bool validationOfChars = false;
//            for (int i = 0; i <= initialCount; i++)
//            {
//                counter++;
//                initialCount--;
//            }
//            if (counter >= 6 && counter <= 10)
//            {
//                validationOfChars = true;
//            }
//            else if (counter < 6 && counter > 10) 
//            {
//                validationOfChars = false;
//            }

//            return validationOfChars;
//        }

//        static bool LettersAndDigitsChecker(string password)
//        {
//            bool validationOfLettersAndDigits = false;
//            bool validator = true;

//            foreach (char c in password) 
//            {
//                if (c < 'a' && c > 'z' && c < 'A' && c > 'Z' && c < '0' && c > '9')
//                {
//                    validator = false;
//                    break;
//                }
//                else 
//                {
//                    validator = true;
//                }
//            }

//            if (validator == true) 
//            {
//                validationOfLettersAndDigits = true;
//            }
//            else 
//            {
//                validationOfLettersAndDigits = false; 
//            }

//            return validationOfLettersAndDigits;
//        }

//        static bool DigitsInPassChecker(string password) 
//        {
//            bool validationOfDigits = false;
//            int counter = 0;

//            foreach (char c in password)
//            {
//                if (c >= '0' && c <= '9')
//                {
//                    counter++;
//                }
//                if (counter >= 2)
//                {
//                    validationOfDigits = true;
//                }
//                else 
//                {
//                    validationOfDigits = false;
//                }
//            }

//            return validationOfDigits;
//        }
//    }
//}
// This is my code which is wrong. I asked ChatGPT for help and it optimized it. I will leave mine here to compare!!!



//ChatGPT's code    |
//                  |
//                  |
//                  |
//                  \/
using System;

namespace _04.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!CharCountChecker(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!LettersAndDigitsChecker(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!DigitsInPassChecker(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CharCountChecker(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool LettersAndDigitsChecker(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c)) // Corrected logic
                {
                    return false;
                }
            }
            return true;
        }

        static bool DigitsInPassChecker(string password)
        {
            int counter = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }

            return counter >= 2; // Corrected logic
        }
    }
}
