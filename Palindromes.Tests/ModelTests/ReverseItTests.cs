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
    public void 
  }
}