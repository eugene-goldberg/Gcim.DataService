using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked
    {
        public Nullable<System.Guid> PerformanceMetricBeingTracked { get; set; }
        public Nullable<System.Guid> PerformanceMetricsTrackingMethods { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
        public virtual PerformanceMetricTrackingMethod PerformanceMetricTrackingMethod { get; set; }
    }
}
