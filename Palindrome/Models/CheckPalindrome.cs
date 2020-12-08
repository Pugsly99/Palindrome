using System;

namespace Palindrome
{
  public class CheckPalindrome
  {
    public static string IsPalindrome(string word)
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
public class Program
  {
    static void Main ()
    {
      Console.WriteLine("Please enter a word");
      string word = Console.ReadLine();
      string flippedWord = CheckPalindrome.IsPalindrome(word);

      bool finalWord = word == flippedWord;

      if (finalWord)
      {
        Console.WriteLine("Is a Palindrome");
      }else
      {
        Console.WriteLine("Is not a Palindrome");  
      }
    }
  }
}