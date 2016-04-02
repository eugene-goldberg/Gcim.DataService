using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives
    {
        public Nullable<System.Guid> SubjectAreaBusinessInitiatives { get; set; }
        public Nullable<System.Guid> BusinessInitiativeSubjectAreas { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
