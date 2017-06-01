using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPokemon.Controllers
{
    public class PokemonModelController : Controller
    {
        // GET: PokemonModel
        public ActionResult findAll()
        {
            return View();
        }
    }
}