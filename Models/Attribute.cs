using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            this.EntityAttributeEntities_AttributeEntityAttributes = new List<EntityAttributeEntities_AttributeEntityAttributes>();
        }

        public System.Guid Oid { get; set; }
        public string AttributeName { get; set; }
        public string Remarks { get; set; }
        public string Source { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<EntityAttributeEntities_AttributeEntityAttributes> EntityAttributeEntities_AttributeEntityAttributes { get; set; }
    }
}
