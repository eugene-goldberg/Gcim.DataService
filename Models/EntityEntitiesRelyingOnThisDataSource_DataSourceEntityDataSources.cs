using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources
    {
        public Nullable<System.Guid> EntityDataSources { get; set; }
        public Nullable<System.Guid> EntitiesRelyingOnThisDataSource { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataSource DataSource { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
