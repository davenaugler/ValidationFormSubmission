using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidatingFormSubmission.Models;

namespace ValidatingFormSubmission.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
      {
        return View();
      }

      [HttpPost("Create")]
        public IActionResult Create(User user)
        {
          if(ModelState.IsValid)
          {
            return RedirectToAction("Success");
          }
          else
          {
            return View("Index");
          }
        }
      
      [HttpGet("Success")]
      public ViewResult Success()
      {
        return View();
      }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
