using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _wordinput;
    private string _sentence;

    public RepeatCounter(string wordinput, string sentence)
    {
      _wordinput = wordinput.ToLower();
      _sentence = sentence.ToLower();
    }

    public string GetWord()
    {
      return _wordinput;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public string RemovePunctuation()
    {
      List<string> sentence = new List<string>{};
      char[] charSentence = _sentence.ToCharArray();
      for (var i=0; i<_sentence.Length; i++)
      {
        if (!char.IsPunctuation(charSentence[i]))
        {
          string singleChar = charSentence[i].ToString();
          sentence.Add(singleChar);
        }
      }
      string stringSentence = sentence.ToString();
      return stringSentence;
    }
    public bool IsSameWord()
    {
      if (_sentence == _wordinput)
      {
        return true;
      }
      return false;
    }
    public string[] GetWordsArray()
    {
      // string sentence = _sentence.ToLower();
      // char[] delimiterChars = {' ', ', ', '. ', ': ', '; ', '/t'};
      string[] wordsArray = _sentence.Split(' ');
      return wordsArray;
    }
  }
}
