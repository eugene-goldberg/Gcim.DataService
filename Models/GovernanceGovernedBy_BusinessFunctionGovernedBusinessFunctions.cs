using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions
    {
        public Nullable<System.Guid> GovernedBusinessFunctions { get; set; }
        public Nullable<System.Guid> GovernedBy { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual Governance Governance { get; set; }
    }
}
