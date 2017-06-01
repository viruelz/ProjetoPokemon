using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPokemon.Controllers
{
    public class TimeModelController : Controller
    {
        // GET: TimeModel
        public ActionResult montarTime()
        {
            return View();
        }

        public ActionResult deletarTime()
        {
            return View();
        }
    }
}