using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerUC.Controllers
{
    public class FeetToMilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult FeetToMiles()
        {
            return View(viewName: "FeetToMiles", model: " ");
        }


        [HttpPost]
        public ActionResult Converter(int Feet, int Miles)
        {
            int Milesconvert;
            int Feetconvert;
            if (Feet != null)
            {
                Milesconvert = (Feet) / 5280;
                return View(viewName: "FeetToMiles", model: (Milesconvert));
            }
            if (Miles != null)
            {
                Feetconvert = (Miles) * 5280;
                return View(viewName: "FeetToMiles", model: (Feetconvert));
            }
        }
    }
}