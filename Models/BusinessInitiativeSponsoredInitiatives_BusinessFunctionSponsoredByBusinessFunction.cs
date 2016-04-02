using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction
    {
        public Nullable<System.Guid> SponsoredByBusinessFunction { get; set; }
        public Nullable<System.Guid> SponsoredInitiatives { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
    }
}
