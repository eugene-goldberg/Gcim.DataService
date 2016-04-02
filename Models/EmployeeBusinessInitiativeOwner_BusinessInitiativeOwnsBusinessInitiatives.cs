using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives
    {
        public Nullable<System.Guid> OwnsBusinessInitiatives { get; set; }
        public Nullable<System.Guid> BusinessInitiativeOwner { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
