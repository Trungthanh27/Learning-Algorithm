namespace LearningDSA.Algo.TwoPointers;

// Chapter 1 - Two Pointers: Is Palindrome Valid
//
// A palindrome is a sequence of characters that reads the same forward and backward.
// Given a string, determine if it's a palindrome after removing all non-alphanumeric
// characters. A character is alphanumeric if it's either a letter or a number.
//
// Constraints:
// - The string may include a combination of lowercase English letters, numbers,
//   spaces, and punctuations.
public static class IsPalindromeValid
{
    public static bool Solve(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
