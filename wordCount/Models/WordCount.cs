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

    public string[] SentenceToWords()
    {
      string[] splitSentence = Sentence.Split(' ');
      return splitSentence;
    }

    public int WordSearchScore(string wordToMatch, char[] sentenceCheck)
    {
      int points = 0;
      for (int i = 0; i < sentenceCheck.Length; i++) 
      {
        bool hasValue = sentenceCheck.TryGetValue(wordToMatch, out string value);
        if (hasValue) 
        {
          points++;
        }
        else
        {
          points = points;
        }
      }
      return points;
    }
  }
}