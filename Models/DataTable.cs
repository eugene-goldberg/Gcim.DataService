using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataTable
    {
        public DataTable()
        {
            this.DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems = new List<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems>();
            this.DataTableAssociatedDataTables_DataSourceAssociatedDataSources = new List<DataTableAssociatedDataTables_DataSourceAssociatedDataSources>();
            this.EntityAssociatedEntities_DataTableAssociatedDataTables = new List<EntityAssociatedEntities_DataTableAssociatedDataTables>();
            this.MasterDataAssociatedMasterData_DataTableAssociatedDataTables = new List<MasterDataAssociatedMasterData_DataTableAssociatedDataTables>();
        }

        public System.Guid Oid { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems> DataTableAssociatedDataTables_DataDictionaryItemAssociatedDataDictionaryItems { get; set; }
        public virtual ICollection<DataTableAssociatedDataTables_DataSourceAssociatedDataSources> DataTableAssociatedDataTables_DataSourceAssociatedDataSources { get; set; }
        public virtual ICollection<EntityAssociatedEntities_DataTableAssociatedDataTables> EntityAssociatedEntities_DataTableAssociatedDataTables { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_DataTableAssociatedDataTables> MasterDataAssociatedMasterData_DataTableAssociatedDataTables { get; set; }
    }
}
