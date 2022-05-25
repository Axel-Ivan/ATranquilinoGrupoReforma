using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ExamenController : Controller
    {
        // GET: Examen
        public ActionResult Form()
        {
            return View();
        }
    }
}