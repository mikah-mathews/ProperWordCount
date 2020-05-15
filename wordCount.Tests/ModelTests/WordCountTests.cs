using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.TestTools
{
  [TestClass]
  public class WordCountTests
  {
    [TestMethod]
    public void Word_WordToCharacters_CharacterArray()
    {
      //Arrange
      Word wordToCheck = new Word ("cat", "There is a Cat");
      char[] target = {'c', 'a', 't'};     
      //Act
      char[] result = wordToCheck.WordToCharacters();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_SentenceToWords_CharacterArray()
    {
      //Arrange
      Word wordToCheck = new Word ("cat", "There is a Cat");
      string[] target = {"There", "is", "a", "Cat"};     
      //Act
      string[] result = wordToCheck.SentenceToWords();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_SetWordCountToZero_Int()
    {
      //Arrange
      Word wordToCheck = new Word ("cat", "There is a Cat");
      int target = 0;     
      //Act
      int result = wordToCheck.WordMatchScore();
      //Assert
      Assert.AreEqual(result, target);
    }

    [TestMethod]
    public void Word_CheckWordInSentence_Int()
    {
      //Arrange
      Word wordToCheck = new Word ("cat", "There is a cat");
      int target = 1;    
      string[] sentencePiece = wordToCheck.SentenceToWords();
      //Act
      int result = wordToCheck.WordSearchScore();
      //Assert
      Assert.AreEqual(result, target);
    }
  }
}