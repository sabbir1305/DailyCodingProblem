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
            ArrayRepo repo = new ArrayRepo();
            var data = new List<int> { 1, 2, 3, 4, 5 };
            var result =  repo.GetProductOfArrayWithoutDiv(data);
            return View();
        }
    }
}
