using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataEntity
    {
        public DataEntity()
        {
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.DataAttributes = new List<DataAttribute>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataDeliveryChannels = new List<DataDeliveryChannel>();
            this.DataSources = new List<DataSource>();
            this.MasterDatas = new List<MasterData>();
            this.SourceTools = new List<SourceTool>();
            this.SubjectAreas = new List<SubjectArea>();
            this.Udms = new List<Udm>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> InformationProduct_ID { get; set; }
        public Nullable<int> BiMeasure_ID { get; set; }
        public Nullable<int> BiFact_ID { get; set; }
        public Nullable<int> BiDimension_ID { get; set; }
        public virtual BiDimension BiDimension { get; set; }
        public virtual BiFact BiFact { get; set; }
        public virtual BiMeasure BiMeasure { get; set; }
        public virtual InformationProduct InformationProduct { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<DataAttribute> DataAttributes { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<DataDeliveryChannel> DataDeliveryChannels { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<MasterData> MasterDatas { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
    }
}
