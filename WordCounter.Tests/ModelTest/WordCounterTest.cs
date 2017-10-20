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
    public void IsSameWord_TwoSameWords_True()
    {
      //Arrange
      RepeatCounter wordMatch = new RepeatCounter("the", "the");
      //Act
      bool isSameWord = wordMatch.IsSameWord();
      //Assert
      Console.WriteLine("Words match: "+ isSameWord);
      Assert.AreEqual(true,isSameWord);
    }
    [TestMethod]
    public void IsSameWord_CaseDifferent_True()
    {
      //Arrange
      RepeatCounter wordMatch = new RepeatCounter("the", "The");
      //Act
      bool isSameWord = wordMatch.IsSameWord();
      //Assert
      Console.WriteLine("Words match: "+ isSameWord);
      Assert.AreEqual(true, isSameWord);
    }
    [TestMethod]
    public void GetWordsArray_StringOfWords_SplitStringIntoWords()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("the", "The cat jumps over the wall");
      //Act
      string[] wordsArray = userInput.GetWordsArray();
      //Assert
      foreach (var word in wordsArray)
      {
        Console.WriteLine(word);
      }
    }
    [TestMethod]
    public void RemovePunctuation_StringOfWords_RemovedPunctiation()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("the", "The cat, Meow jumps over the wall");
      //Act
      string newSentence = userInput.RemovePunctuation();
      //Assert
      Console.WriteLine(newSentence);
    }
    [TestMethod]
    public void CountRepeats_StringOfWords_ReturnRepeatedCount()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("the", "The cat, Meow jumps over the wall");
      //Act
      int numberOfRepeats = userInput.CountRepeats();
      //Assert
      Console.WriteLine(numberOfRepeats);
    }
  }
}
