using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class DataDiscoveryMethod
    {
        public DataDiscoveryMethod()
        {
            this.PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods = new List<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods>();
        }

        public System.Guid Oid { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods> PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods { get; set; }
    }
}
