using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GovernanceGovernsOver_EmployeeGoverningEmployees
    {
        public Nullable<System.Guid> GoverningEmployees { get; set; }
        public Nullable<System.Guid> GovernsOver { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Governance Governance { get; set; }
    }
}
