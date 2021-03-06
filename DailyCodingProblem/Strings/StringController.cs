using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Strings
{
    public class StringController : Controller
    {
        public IActionResult Index()
        {
          
            var Repo = new StringRepo();
            string[] words = { "code", "edoc", "da", "d" };
  
            var returendResulty = Repo.GeneratePalindromePairs(words);
            return View();
        }
    }
}
