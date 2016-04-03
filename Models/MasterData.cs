using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MasterData
    {
        public MasterData()
        {
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataEntities = new List<DataEntity>();
            this.DataSources = new List<DataSource>();
            this.SourceTools = new List<SourceTool>();
        }

        public int ID { get; set; }
        public string MasterDataEntityName { get; set; }
        public string MasterDataAttributeName { get; set; }
        public string MasterDataAuthoritativeSystemName { get; set; }
        public string MasterDataSourceLink { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
    }
}
