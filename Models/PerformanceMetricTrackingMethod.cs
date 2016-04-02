using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricTrackingMethod
    {
        public PerformanceMetricTrackingMethod()
        {
            this.PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked = new List<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked>();
        }

        public System.Guid Oid { get; set; }
        public string MethodName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked> PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked { get; set; }
    }
}
