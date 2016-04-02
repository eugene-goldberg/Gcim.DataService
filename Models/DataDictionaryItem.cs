using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDictionaryItem
    {
        public DataDictionaryItem()
        {
            this.DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems = new List<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems>();
        }

        public System.Guid Oid { get; set; }
        public Nullable<System.Guid> Entity { get; set; }
        public string AttributeName { get; set; }
        public string DataType { get; set; }
        public string BusinessMeaning { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual Entity Entity1 { get; set; }
        public virtual ICollection<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems> DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems { get; set; }
    }
}
