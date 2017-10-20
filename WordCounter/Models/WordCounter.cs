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
      _wordinput = wordinput;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _wordinput;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public bool IsSameWord(string newword)
    {
      if (newword == _wordinput)
      {
        return true;
      }
      return false;
    }
    public string[] GetWordsArray()
    {
      string sentence = _sentence.ToLower();
      // char[] delimiterChars = {' ', ', ', '. ', ': ', '; ', '/t'};
      string[] wordsArray = sentence.Split(' ');
      return wordsArray;
    }
  }
}
