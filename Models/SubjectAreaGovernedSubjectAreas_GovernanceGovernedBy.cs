using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy
    {
        public Nullable<System.Guid> GovernedBy { get; set; }
        public Nullable<System.Guid> GovernedSubjectAreas { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Governance Governance { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
