using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class ObjectField
    {
        public ObjectField()
        {
            this.FieldMaps = new List<FieldMap>();
        }

        public int OID { get; set; }
        public string BOTypeName { get; set; }
        public string BOFieldName { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<FieldMap> FieldMaps { get; set; }
    }
}
