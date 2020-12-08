namespace Palindromes.Models
{
  public class ReverseIt
  {
    public char[] IsReverseIt(string word)
    {
        
        char[] wordArray = word.ToCharArray();
        Array.Reverse(wordArray);
        return wordArray;
    }
  }
} 