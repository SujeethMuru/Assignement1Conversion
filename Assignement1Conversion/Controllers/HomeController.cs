using Microsoft.AspNetCore.Mvc;
using Assignement1Conversion.Models;
using System.Diagnostics;

namespace Assignement1Conversion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(ConversionModel model)
        { 
            ViewBag.ErrorCheckResult = model.CheckForErrors();
            return View(model);
        }

    }
}
