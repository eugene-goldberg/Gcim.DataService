using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class AnalyticalMethod
    {
        public AnalyticalMethod()
        {
            this.PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods = new List<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods>();
        }

        public System.Guid Oid { get; set; }
        public string MethodName { get; set; }
        public string MethodDefinition { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods> PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods { get; set; }
    }
}
