using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    public string Letters {get; set;}
    public string Sentence {get; set;}

    public Word (string letters, string sentence)
    {
      Letters = letters;
      Sentence = sentence;
    }

    public char[] WordToCharacters()
    {
      char[] letterArray = Letters.ToCharArray();
      return letterArray;
    }

    public char[] SentenceToWords()
    {
      string[] splitSentence = Sentence.Split(' ');
      Console.WriteLine(splitSentence);
      char[] deconstructedSentence = splitSentence.toCharArray();
      return deconstructedSentence;
    }
  }
}