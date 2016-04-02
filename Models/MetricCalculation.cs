using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MetricCalculation
    {
        public MetricCalculation()
        {
            this.PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations = new List<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations>();
        }

        public System.Guid Oid { get; set; }
        public string CalculationName { get; set; }
        public string Definition { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations> PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations { get; set; }
    }
}
