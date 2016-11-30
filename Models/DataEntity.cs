using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataEntity
    {
        public DataEntity()
        {
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.DataDeliveryChannels = new List<DataDeliveryChannel>();
            this.DataSources = new List<DataSource>();
            this.MasterDatas = new List<MasterData>();
            this.OdsDataAttributes = new List<OdsDataAttribute>();
            this.SourceTools = new List<SourceTool>();
            this.SubjectAreas = new List<SubjectArea>();
            this.UdmDataAttributes = new List<UdmDataAttribute>();
            this.Udms = new List<Udm>();
            this.UdmDimensions = new List<UdmDimension>();
            this.UdmFacts = new List<UdmFact>();
            this.UdmMeasures = new List<UdmMeasure>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> InformationProduct_ID { get; set; }
        public virtual InformationProduct InformationProduct { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        [AutoExpand]
        public virtual ICollection<DataDeliveryChannel> DataDeliveryChannels { get; set; }
        [AutoExpand]
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<MasterData> MasterDatas { get; set; }
        [AutoExpand]
        public virtual ICollection<OdsDataAttribute> OdsDataAttributes { get; set; }
        [AutoExpand]
        public virtual ICollection<SourceTool> SourceTools { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
        [AutoExpand]
        public virtual ICollection<UdmDataAttribute> UdmDataAttributes { get; set; }
        public virtual ICollection<Udm> Udms { get; set; }
        [AutoExpand]
        public virtual ICollection<UdmDimension> UdmDimensions { get; set; }
        [AutoExpand]
        public virtual ICollection<UdmFact> UdmFacts { get; set; }
        [AutoExpand]
        public virtual ICollection<UdmMeasure> UdmMeasures { get; set; }
    }
}
