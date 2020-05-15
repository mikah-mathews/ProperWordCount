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
      Word wordToCheck = new Word ("cat");
      char[] target = {'c', 'a', 't'};     
      //Act
      char[] result = myWord.WordToCharacters();
      //Assert
      CollectionAssert.AreEqual(result, target);
    }
  }
}