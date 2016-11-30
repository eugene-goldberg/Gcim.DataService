using SelfHostedWebApiDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;

namespace SelfHostedWebApiDataService.Controllers
{
     [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InformationProductController : ODataController
    {
        GCIMContext db = new GCIMContext();

        [AcceptVerbs("OPTIONS")]
        public HttpResponseMessage Options()
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Headers.Add("Access-Control-Allow-Origin", "*");
            resp.Headers.Add("Access-Control-Allow-Methods", "GET,DELETE,POST,PUT");

            return resp;
        }

        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [EnableQuery]
        public IQueryable<InformationProduct> Get()
        {
            return db.InformationProducts;
        }
    }
}
