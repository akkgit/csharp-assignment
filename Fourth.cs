using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public class Fourth
    {
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = input.Length - 1;

            // Swap characters from left and right ends until the pointers meet in the middle
            while (left < right)
            {
                // Swap characters
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                // Move pointers towards the center
                left++;
                right--;
            }

            // Convert the character array back to a string
            return new string(charArray);
        }

        public static int CalculateStringLength(string input)
        {
            int length = 0;

            // Iterate through the characters of the string and count them
            foreach (char character in input)
            {
                length++;
            }

            return length;
        }

        public static int CalculateStringLengthWithCount(string input)
        {
            return input.Count();
        }

        public static string ReplaceString(string input, string substringToReplace, string replacementString)
        {
            // Use Replace function to replace the substring
            string modifiedString = input.Replace(substringToReplace, replacementString);
            return modifiedString;
        }

        public static string ConvertToLowerCase(string input)
        {
            // Use ToLower() method to convert the input string to lowercase
            return input.ToLower();
        }

        public static char FindMaxOccurringCharacter(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count occurrences of each character in the string
            foreach (char character in input)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                }
                else
                {
                    charCount[character] = 1;
                }
            }

            char maxChar = '\0';
            int maxCount = 0;

            // Find the maximum occurring character
            foreach (var pair in charCount)
            {
                if (pair.Value > maxCount)
                {
                    maxChar = pair.Key;
                    maxCount = pair.Value;
                }
            }

            return maxChar;
        }

        public static string SortStringInAscendingOrder(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Sort(charArray);

            // Convert the sorted character array back to a string
            string sortedString = new string(charArray);
            return sortedString;
        }
    }
}
