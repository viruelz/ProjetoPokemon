using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoPokemon.Controllers.Api
{
    public class TimeModelController : ApiController
    {
        // GET: api/TimeModel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TimeModel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TimeModel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TimeModel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TimeModel/5
        public void Delete(int id)
        {
        }
    }
}
