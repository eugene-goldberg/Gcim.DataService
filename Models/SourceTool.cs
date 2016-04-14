using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SourceTool
    {
        public SourceTool()
        {
            this.InformationProducts = new List<InformationProduct>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataEntities = new List<DataEntity>();
            this.DataSources = new List<DataSource>();
            this.MasterDatas = new List<MasterData>();
            this.Udms = new List<Udm>();
        }

        public int ID { get; set; }
        public string ToolInstanceName { get; set; }
        public string Description { get; set; }
        public string OdsDatabaseName { get; set; }
        public string IntroducingProject { get; set; }
        public System.DateTime DateRecorded { get; set; }
        public bool InUse { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Governance_ID { get; set; }
        public Nullable<int> BusinessInitiative_ID { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual Governance Governance { get; set; }
        public virtual ICollection<InformationProduct> InformationProducts { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<MasterData> MasterDatas { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
    }
}
