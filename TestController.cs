using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostedWebApiDataService
{
    public class TestController : ApiController
    {
        // GET api/demo 
        public IEnumerable<string> Get()
        {
            return new string[] { "This is Test Controller" };
        }

        // GET api/demo/5 
        public string Get(int id)
        {
            return "Test Controller " + id;
        }

        // POST api/demo 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/demo/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/demo/5 
        public void Delete(int id)
        {
        }
    } 
}
