using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ServerUC.Controllers
{
    public class KimController : Controller
    {
        public ActionResult CmToM()
        {
            return View(viewName: "CmtoM", model: 0.0);
        }

        [HttpPost]
        public ActionResult convert(double centimeter)
        {
            return View(viewName: "CmtoM", model: centimeter/100);
        }
    }
}