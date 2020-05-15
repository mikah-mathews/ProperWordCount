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
      char[] target = {'There', 'is', 'a', 'Cat'};     
      //Act
      char[] result = sentenceToCheck.SentenceToWords();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }
  }
}