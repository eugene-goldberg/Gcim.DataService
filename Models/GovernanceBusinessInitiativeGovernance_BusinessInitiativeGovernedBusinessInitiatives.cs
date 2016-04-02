using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives
    {
        public Nullable<System.Guid> GovernedBusinessInitiatives { get; set; }
        public Nullable<System.Guid> BusinessInitiativeGovernance { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual Governance Governance { get; set; }
    }
}
