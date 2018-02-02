using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DOSApplication.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new DOSApplication.ViewModels.DistanceCalculatorViewModel
            {
                Heading = "Calculate Distance"
            };
            return View("DistanceCalculator", viewModel);
        }
    }
}
