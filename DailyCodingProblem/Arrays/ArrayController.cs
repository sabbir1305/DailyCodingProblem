using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCodingProblem.Arrays
{
    public class ArrayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
