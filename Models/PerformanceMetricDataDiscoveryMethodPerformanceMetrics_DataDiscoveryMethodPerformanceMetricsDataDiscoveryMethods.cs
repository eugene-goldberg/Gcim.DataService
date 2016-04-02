using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods
    {
        public Nullable<System.Guid> PerformanceMetricsDataDiscoveryMethods { get; set; }
        public Nullable<System.Guid> DataDiscoveryMethodPerformanceMetrics { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual DataDiscoveryMethod DataDiscoveryMethod { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
