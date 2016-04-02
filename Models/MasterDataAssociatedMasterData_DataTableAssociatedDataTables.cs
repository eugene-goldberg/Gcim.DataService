using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MasterDataAssociatedMasterData_DataTableAssociatedDataTables
    {
        public Nullable<System.Guid> AssociatedDataTables { get; set; }
        public Nullable<System.Guid> AssociatedMasterData { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataTable DataTable { get; set; }
        public virtual MasterData MasterData { get; set; }
    }
}
