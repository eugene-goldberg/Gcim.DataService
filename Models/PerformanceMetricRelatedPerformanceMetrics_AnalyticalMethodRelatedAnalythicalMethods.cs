using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods
    {
        public Nullable<System.Guid> RelatedAnalythicalMethods { get; set; }
        public Nullable<System.Guid> RelatedPerformanceMetrics { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual AnalyticalMethod AnalyticalMethod { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
