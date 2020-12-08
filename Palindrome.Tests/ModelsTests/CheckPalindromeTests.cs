using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class CheckPalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_IsAPalindrome_True()
    {
      CheckPalindrome testPalindrome = new CheckPalindrome();
      Assert.AreEqual("wow", testPalindrome.IsPalindrome("wow"));
    }
  }
}