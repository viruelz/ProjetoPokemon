using Model.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace ProjetoPokemon.Controllers
{
    public class TimeModelController : Controller
    {
        // GET: TimeModel
        public ActionResult mostrarTime()
        {
            ViewBag.ListTime = findTimeById();
            return View();
        }

        public ActionResult montarTime()
        {
            return View();
        }

        public ActionResult deletarTime()
        {
            return View();
        }

        public ICollection<TimeModel> findTimeById()
        {
            try
            {
                HttpClient client = new HttpClient();
                var baseUrl = "endereço WS";
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/jason"));
                HttpResponseMessage response = client.GetAsync("TimeModel'view'").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<ICollection<TimeModel>>().Result;
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