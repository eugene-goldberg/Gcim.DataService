using SelfHostedWebApiDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;

namespace SelfHostedWebApiDataService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChangeRecordController : ODataController
    {
        GCIMContext db = new GCIMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<ChangeRecord> Get()
        {
            return db.ChangeRecords;
        }

        public async Task<IHttpActionResult> Post(ChangeRecord record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.ChangeRecords.Add(record);
            db.SaveChanges();
            return Created(record);
        }
    }
}
