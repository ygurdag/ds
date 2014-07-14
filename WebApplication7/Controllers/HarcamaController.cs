using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HarcamaController : ApiController
    {
       


        // GET: api/Harcama
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Harcama/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Harcama
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Harcama/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Harcama/5
        public void Delete(int id)
        {
        }
    }
}
