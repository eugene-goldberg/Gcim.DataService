using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataSource
    {
        public DataSource()
        {
            this.DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels = new List<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels>();
            this.DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource = new List<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource>();
            this.DataTableAssociatedDataTables_DataSourceAssociatedDataSources = new List<DataTableAssociatedDataTables_DataSourceAssociatedDataSources>();
            this.EmployeeDataSourceOwners_DataSourceOwnsDatasources = new List<EmployeeDataSourceOwners_DataSourceOwnsDatasources>();
            this.EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources = new List<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources>();
            this.GambiToolSupportedGambiTools_DataSourceSupportingDataSources = new List<GambiToolSupportedGambiTools_DataSourceSupportingDataSources>();
            this.MasterDataAssociatedMasterData_DataSourceAssociatedDataSources = new List<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources>();
        }

        public System.Guid Oid { get; set; }
        public string Category { get; set; }
        public string DataSourceInstance { get; set; }
        public string SystemTeam { get; set; }
        public string SystemOwner { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemLocation { get; set; }
        public string SourceSystemNetworkSegment { get; set; }
        public string SourceSystemOsType { get; set; }
        public string SourceDatabaseName { get; set; }
        public string SourceDatabaseType { get; set; }
        public string SourceDatabaseVersion { get; set; }
        public string IsNewRecord { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels> DataSourceChannelDataSources_DataDeliveryChannelDeliveredThroughChannels { get; set; }
        public virtual ICollection<DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource> DataSourceDataSourcesWhichSupportThisAccount_AccountAccountsSupportedByThisDataSource { get; set; }
        public virtual ICollection<DataTableAssociatedDataTables_DataSourceAssociatedDataSources> DataTableAssociatedDataTables_DataSourceAssociatedDataSources { get; set; }
        public virtual ICollection<EmployeeDataSourceOwners_DataSourceOwnsDatasources> EmployeeDataSourceOwners_DataSourceOwnsDatasources { get; set; }
        public virtual ICollection<EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources> EntityEntitiesRelyingOnThisDataSource_DataSourceEntityDataSources { get; set; }
        public virtual ICollection<GambiToolSupportedGambiTools_DataSourceSupportingDataSources> GambiToolSupportedGambiTools_DataSourceSupportingDataSources { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_DataSourceAssociatedDataSources> MasterDataAssociatedMasterData_DataSourceAssociatedDataSources { get; set; }
    }
}
