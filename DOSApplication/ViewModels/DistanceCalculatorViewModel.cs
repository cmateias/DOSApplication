using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace DOSApplication.ViewModels
{
    public class DistanceCalculatorViewModel
    {
        public string Heading { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public string Mode { get; set; }

        public string Action
        {
            get
            {
                Expression<Func<DOSApplication.Controllers.DistanceCalculatorController, ActionResult>> calculate = (c => c.Calculate(this));
                return (calculate.Body as MethodCallExpression).Method.Name;
            }
        }
    }
}