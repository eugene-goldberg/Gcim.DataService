using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaEntitySubjectAreas_EntitySubjectAreaEntities
    {
        public Nullable<System.Guid> SubjectAreaEntities { get; set; }
        public Nullable<System.Guid> EntitySubjectAreas { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
