using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataTableAssociatedDataTables_DataSourceAssociatedDataSources
    {
        public Nullable<System.Guid> AssociatedDataSources { get; set; }
        public Nullable<System.Guid> AssociatedDataTables { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataSource DataSource { get; set; }
        public virtual DataTable DataTable { get; set; }
    }
}
