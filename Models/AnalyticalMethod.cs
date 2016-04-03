using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class AnalyticalMethod
    {
        public AnalyticalMethod()
        {
            this.BusinessQuestions = new List<BusinessQuestion>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
        }

        public int ID { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public Nullable<int> InformationProduct_ID { get; set; }
        public string Calculation { get; set; }
        public virtual InformationProduct InformationProduct { get; set; }
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
    }
}
