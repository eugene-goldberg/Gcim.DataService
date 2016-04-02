using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class InformationComponentRelatedInformationComponents_EntityRelatedEntities
    {
        public Nullable<System.Guid> RelatedEntities { get; set; }
        public Nullable<System.Guid> RelatedInformationComponents { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual InformationComponent InformationComponent { get; set; }
    }
}
