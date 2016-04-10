using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class InformationProduct
    {
        public InformationProduct()
        {
            this.AnalyticalMethods = new List<AnalyticalMethod>();
            this.DataEntities = new List<DataEntity>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.SourceTools = new List<SourceTool>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Governance_ID { get; set; }
        public Nullable<int> PerformanceMetric_ID { get; set; }
        public virtual ICollection<AnalyticalMethod> AnalyticalMethods { get; set; }
        [AutoExpand]
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual Governance Governance { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
    }
}
