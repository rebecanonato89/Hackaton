using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Hackaton.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("api/Values")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        [Route("api/Values")]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        [Route("api/Values")]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
