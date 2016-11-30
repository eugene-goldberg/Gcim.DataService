﻿using SelfHostedWebApiDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using System.Web.OData;

namespace SelfHostedWebApiDataService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BusinessFunctionController : ODataController
    {
        GCIMContext db = new GCIMContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<BusinessFunction> Get()
        {
            return db.BusinessFunctions;
        }
    }
}
