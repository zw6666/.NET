using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataMining;

namespace Music.Controllers
{
    public class SingerController : ApiController
    {
        // GET: api/Singer
        public SearchData Get([FromBody]string keyword)
        {
            return Creeper.GetSearchResult(keyword);
        }

        // GET: api/Singer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Singer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Singer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Singer/5
        public void Delete(int id)
        {
        }
    }
}
