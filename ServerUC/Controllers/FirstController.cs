using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServerUC.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult BaseConversion()
        {
            return View(viewName: "BaseConversion", model: " ");
        }
        [HttpPost]
        public ActionResult BaseConversion(int startNumber)
        {
            return View("BaseConversion", model: "Your number will be: " + Convert.ToString(startNumber, 2));
        }
    }
}