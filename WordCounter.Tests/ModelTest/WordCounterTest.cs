using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.TestTools
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsSameWord_ReturnBool_True()
    {
      //Arrange
      RepeatCounter wordMatch = new RepeatCounter("the", "the");
      //Act
      bool isSameWord = wordMatch.IsSameWord("the");
      //Assert
      Console.WriteLine("Words match: "+ isSameWord);
      Assert.AreEqual(true,isSameWord);
    }
  }
}
