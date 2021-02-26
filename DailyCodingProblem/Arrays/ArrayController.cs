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
            var arr = new int[] {34,-50,42,14,-5,86 };
            var result2 =  repo.MaximumCircularSubArray(arr);
            return View();
        }
    }
}
