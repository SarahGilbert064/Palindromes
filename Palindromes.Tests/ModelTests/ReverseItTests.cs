using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class ReverseItTests
  {
    [TestMethod]
    public void IsReverseIt_StringToChar_Char()
    {
      ReverseIt testReverseIt = new ReverseIt();
      CollectionAssert.AreEqual(new char[]{'h', 'e', 'l', 'l', 'o'}, testReverseIt.IsReverseIt("hello"));
    }

    [TestMethod]
    public void IsReverseIt_ReverseArray_Reverse()
    {
      ReverseIt testReverseIt = new ReverseIt();
      CollectionAssert.AreEqual(new char[]{'o', 'l', 'l', 'e', 'h'}, testReverseIt.IsReverseArray(new char[]{'h', 'e', 'l', 'l', 'o'}));
    }

    [TestMethod]
    public void IsReverseIt_ReverseArrayToStr_ToString()
    {
      ReverseIt testReverseIt = new ReverseIt();
      Assert.AreEqual(new string("olleh") , testReverseIt.IsReverseStr(new char[]{'o', 'l', 'l', 'e', 'h'}));
    }

    [TestMethod]
    public void IsReverseIt_CompareRevWord_False()
    {
      ReverseIt testReverseIt = new ReverseIt();
      Assert.AreEqual(false, testReverseIt.IsPalindrome("olleh", "hello"));
    }
  }
}