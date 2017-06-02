using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPokemon.Controllers
{
    public class PokemonModelController : Controller
    {
        // GET: PokemonModel
        public ActionResult findAll()
        {
            ViewBag.ListTime = findAllPokeById();
            return View();
        }

        public ICollection<PokemonModel> findAllPokeById()
        {
            try
            {
                HttpClient client = new HttpClient();
                var baseUrl = "endereço WS";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/jason"));
                HttpResponseMessage response = client.GetAsync("PokemonModel'view'").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<ICollection<PokemonModel>>().Result;
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
  
}