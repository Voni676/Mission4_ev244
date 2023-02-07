using Microsoft.AspNetCore.Mvc;
using Mission4_ev244.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_ev244.Controllers
{
    public class subfolderController : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException();

            return View();
        }
        // getting GradeCalc Page (get)
        [HttpGet] //attribute
        public IActionResult GradeCalc()
        {
            return View();
        }
        // submiting form (post)
        [HttpPost]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            return View();
        }
    }
}
