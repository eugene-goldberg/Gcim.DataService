using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataSource
    {
        public DataSource()
        {
            this.DataDeliveryChannels = new List<DataDeliveryChannel>();
            this.DataEntities = new List<DataEntity>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.Employees = new List<Employee>();
            this.Governances = new List<Governance>();
            this.MasterDatas = new List<MasterData>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.SourceTools = new List<SourceTool>();
        }

        public int ID { get; set; }
        public string Category { get; set; }
        public string SourceSystemName { get; set; }
        public string SourceSystemOwner { get; set; }
        public string SourceSystemLocation { get; set; }
        public string SourceSystemTeam { get; set; }
        public string SourceSystemNetworkSegment { get; set; }
        public string SourceSystemOsType { get; set; }
        public string SourceDatabaseName { get; set; }
        public string SourceDatabaseType { get; set; }
        public string SourceDatabaseVersion { get; set; }
        public Nullable<int> BiFact_ID { get; set; }
        public virtual BiFact BiFact { get; set; }
        public virtual ICollection<DataDeliveryChannel> DataDeliveryChannels { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
        public virtual ICollection<MasterData> MasterDatas { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
    }
}
