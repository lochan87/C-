using System;
using System.Text.RegularExpressions;

class PalindromeChecker
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a string or number to check for Palindrome: ");
            string input = Console.ReadLine();

            if (IsNumeric(input))
            {
                if (IsPalindrome(input))
                    Console.WriteLine("It's a palindrome number!");
                else
                    Console.WriteLine("It's not a palindrome number.");
                break;
            }
            else if (IsAlphabetic(input))
            {
                if (IsPalindrome(input))
                    Console.WriteLine("It's a palindrome string!");
                else
                    Console.WriteLine("It's not a palindrome string.");
                break;
            }
            else
            {
                Console.WriteLine("Input contains both letters and numbers. Please enter only numbers or only alphabets.\n");
            }
        }
    }

    static bool IsNumeric(string input)
    {
        return Regex.IsMatch(input, @"^\d+$");
    }

    static bool IsAlphabetic(string input)
    {
        return Regex.IsMatch(input, @"^[a-zA-Z]+$");
    }

    static bool IsPalindrome(string text)
    {
        string cleaned = text.ToLower();
        char[] arr = cleaned.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return cleaned == reversed;
    }
}
