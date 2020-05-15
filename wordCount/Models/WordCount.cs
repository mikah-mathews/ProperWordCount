using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    public string Letters {get; set;}
    public string Sentence {get; set;}

    public Word (string letters)
    {
      Letters = letters;
    }

    public Sentence (string sentence)
    {
      Sentence = sentence;
    }

    public char[] WordToCharacters()
    {
      char[] letterArray = Letters.ToCharArray();
      return letterArray;
    }

    public char[] SentenceToWords()
    {
      char[] deconstructedSentence = Sentence.Split(' ');
      return deconstructedSentence;
    }
  }
}