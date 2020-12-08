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
  }
} 