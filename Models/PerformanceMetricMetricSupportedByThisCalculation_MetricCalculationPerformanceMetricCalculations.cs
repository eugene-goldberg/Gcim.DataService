using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations
    {
        public Nullable<System.Guid> PerformanceMetricCalculations { get; set; }
        public Nullable<System.Guid> MetricSupportedByThisCalculation { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual MetricCalculation MetricCalculation { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
