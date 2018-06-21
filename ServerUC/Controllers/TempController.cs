using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerUC.Controllers
{
    public class TempController : Controller
    {
        public ActionResult CelsiusToFahrenheit()
        {
            return View(viewName: "CelsiusToFahrenheit", model: 0.0);
        }

        [HttpPost]
        public ActionResult CtoF(double inputC)
        {
            return View(viewName: "CelsiusToFahrenheit", model: inputC * (9 / 5) + 32);
        }
    }
}