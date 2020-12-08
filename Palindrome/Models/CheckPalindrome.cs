using System;

namespace Palindrome
{
  public class CheckPalindrome
  {
    public string IsPalindrome(string word)
    { 
      char[] charArray = word.ToCharArray();
      int len = word.Length - 1;

      for (int i = 0; i < len; i++, len--)
      {
        charArray[i] ^= charArray[len];
        charArray[len] ^= charArray[i];
        charArray[i] ^= charArray[len];
      }
      return new string(charArray);
    }
  }
}
public class Program
  {
    static void Main ()
    {
      string word = Console.ReadLine();
      IsPalindrome reverseWord =  new IsPalindrome(word);

      bool checkWord = reverseWord == word;

      if (checkWord)
      {
        Console.WriteLine("Is a Palindrome");
      }else
      {
        Console.WriteLine("Is not a Palindrome");  
      }
    }
  }