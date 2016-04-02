using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class GambiTool
    {
        public GambiTool()
        {
            this.GambiToolOwnsGambiTools_EmployeeToolOwners = new List<GambiToolOwnsGambiTools_EmployeeToolOwners>();
            this.GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives = new List<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives>();
            this.GambiToolSupportedGambiTools_DataSourceSupportingDataSources = new List<GambiToolSupportedGambiTools_DataSourceSupportingDataSources>();
            this.GambiToolUsedInGambiTools_EntityReliesOnEntities = new List<GambiToolUsedInGambiTools_EntityReliesOnEntities>();
            this.MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools = new List<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools>();
        }

        public System.Guid Oid { get; set; }
        public string ToolName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<GambiToolOwnsGambiTools_EmployeeToolOwners> GambiToolOwnsGambiTools_EmployeeToolOwners { get; set; }
        public virtual ICollection<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives> GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives { get; set; }
        public virtual ICollection<GambiToolSupportedGambiTools_DataSourceSupportingDataSources> GambiToolSupportedGambiTools_DataSourceSupportingDataSources { get; set; }
        public virtual ICollection<GambiToolUsedInGambiTools_EntityReliesOnEntities> GambiToolUsedInGambiTools_EntityReliesOnEntities { get; set; }
        public virtual ICollection<MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools> MasterDataAssociatedMasterData_GambiToolAssociatedGambiTools { get; set; }
    }
}
