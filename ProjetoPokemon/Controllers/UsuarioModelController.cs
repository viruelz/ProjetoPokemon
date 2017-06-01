using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPokemon.Controllers
{
    public class UsuarioModelController : Controller
    {
        // GET: UsuarioModel
        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Logar()
        {
            return View();
        }
    }
}