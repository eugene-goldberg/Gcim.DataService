using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MasterData
    {
        public MasterData()
        {
            this.MasterDataAssociatedMasterData_DataSourceAssociatedDataSources = new List<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources>();
            this.MasterDataAssociatedMasterData_DataTableAssociatedDataTables = new List<MasterDataAssociatedMasterData_DataTableAssociatedDataTables>();
            this.MasterDataAssociatedMasterData_EntityAssociatedEntities = new List<MasterDataAssociatedMasterData_EntityAssociatedEntities>();
            this.MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools = new List<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools>();
        }

        public System.Guid Oid { get; set; }
        public string MasterDataEntityName { get; set; }
        public string MasterDataElementName { get; set; }
        public string MasterDataAuthoritativeSystemName { get; set; }
        public string MasterDataLink { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources> MasterDataAssociatedMasterData_DataSourceAssociatedDataSources { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_DataTableAssociatedDataTables> MasterDataAssociatedMasterData_DataTableAssociatedDataTables { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_EntityAssociatedEntities> MasterDataAssociatedMasterData_EntityAssociatedEntities { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools> MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools { get; set; }
    }
}
