using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class EmployeeDataSourceOwners_DataSourceOwnsDatasources
    {
        public Nullable<System.Guid> OwnsDatasources { get; set; }
        public Nullable<System.Guid> DataSourceOwners { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataSource DataSource { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
