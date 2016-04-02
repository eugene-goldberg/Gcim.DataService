using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EntityAssociatedEntities_DataTableAssociatedDataTables
    {
        public Nullable<System.Guid> AssociatedDataTables { get; set; }
        public Nullable<System.Guid> AssociatedEntities { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataTable DataTable { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
