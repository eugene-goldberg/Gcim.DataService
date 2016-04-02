using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectAreaInformationComponentsSubjectArea_InformationComponentSubjectAreaInformationComponents
    {
        public Nullable<System.Guid> SubjectAreaInformationComponents { get; set; }
        public Nullable<System.Guid> InformationComponentsSubjectArea { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual InformationComponent InformationComponent { get; set; }
        public virtual SubjectArea SubjectArea { get; set; }
    }
}
