using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/results")]
    public ActionResult WordCounter()
    {
      RepeatCounter userInput = new RepeatCounter(Request.Form["wordInput"], Request.Form["sentenceInput"]);
      string Word = userInput.GetWord();
      string Sentence = userInput.GetSentence();
      int repeats = userInput.CountRepeats();
      string Repeats = repeats.ToString();

      Dictionary<string, string> WordCount = new Dictionary<string, string> () {{"Word", Word}, {"Sentence", Sentence}, {"Repeats", Repeats}};

      return View(WordCount);
    }
  }

}
