using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions
    {
        public Nullable<System.Guid> AssociatedBusinessFunctions { get; set; }
        public Nullable<System.Guid> AssociatedSubjectAreas { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessFunction BusinessFunction { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
