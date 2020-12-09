using System;
namespace Palindromes.Models
{
  public class ReverseIt
  {
    public char[] IsReverseIt(string word)
    {
        
        char[] wordArray = word.ToCharArray();
        return wordArray;
    }

    public char[] IsReverseArray(char[] wordArray)
    {
        Array.Reverse(wordArray);
        return wordArray;
    }

    public string IsReverseStr(char[] wordArray)
    {
        string finalOutput = new string(wordArray);
        return finalOutput;
    }
    public bool IsPalindrome(string finalOutput, string word)
    {
        if (finalOutput == word)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
  }
} 