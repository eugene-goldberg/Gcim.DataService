using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal
    {
        public Nullable<System.Guid> PerformanceMetricsBusinessGoal { get; set; }
        public Nullable<System.Guid> BusinessGoalPerformanceMetrics { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessGoal BusinessGoal { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
