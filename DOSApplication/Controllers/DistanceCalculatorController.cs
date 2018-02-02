using System;
using System.Collections.Generic;
using DOSApplication.ViewModels;
using DOSApplication.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSApplication.Controllers
{
    public class DistanceCalculatorController:Controller
    {
        [HttpPost]
        public ActionResult Calculate(DistanceCalculatorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Heading = "Calculate Distance";
                return View("DistanceCalculator", viewModel);
            }
            
            var distance = new DistanceRequest
            {
                Origin = viewModel.Origin,
                Destination = viewModel.Destination,
                Mode = viewModel.Mode
            };
           return RedirectToAction("Index", "DistanceResult", distance);
        }
    }
}