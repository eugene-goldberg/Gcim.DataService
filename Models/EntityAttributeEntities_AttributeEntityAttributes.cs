using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EntityAttributeEntities_AttributeEntityAttributes
    {
        public Nullable<System.Guid> EntityAttributes { get; set; }
        public Nullable<System.Guid> AttributeEntities { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual Attribute Attribute { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
