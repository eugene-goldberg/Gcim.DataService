using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems
    {
        public Nullable<System.Guid> AssociatedDataDictionaryItems { get; set; }
        public Nullable<System.Guid> AssociatedDataTables { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataDictionaryItem DataDictionaryItem { get; set; }
        public virtual DataTable DataTable { get; set; }
    }
}
