using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricMockupForMetric_MetricMockupMetricMockups
    {
        public Nullable<System.Guid> MetricMockups { get; set; }
        public Nullable<System.Guid> MockupForMetric { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual MetricMockup MetricMockup { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
