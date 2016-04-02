using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EntityOwnedEntities_EmployeeEntityOwners
    {
        public Nullable<System.Guid> EntityOwners { get; set; }
        public Nullable<System.Guid> OwnedEntities { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
