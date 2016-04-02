using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GambiToolUsedInGambiTools_EntityReliesOnEntities
    {
        public Nullable<System.Guid> ReliesOnEntities { get; set; }
        public Nullable<System.Guid> UsedInGambiTools { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual GambiTool GambiTool { get; set; }
    }
}
