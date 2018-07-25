using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppPlugin1.ViewModels;

namespace WebAppPlugin1.Controllers
{
    public class Plugin1HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestViewModel { Value = "Test Value" };
            return View(model);
        }
    }
}
