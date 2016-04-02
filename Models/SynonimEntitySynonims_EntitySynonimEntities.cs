using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SynonimEntitySynonims_EntitySynonimEntities
    {
        public Nullable<System.Guid> SynonimEntities { get; set; }
        public Nullable<System.Guid> EntitySynonims { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Synonim Synonim { get; set; }
    }
}
