using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives
    {
        public Nullable<System.Guid> PerformanceMetricBusinessInitiatives { get; set; }
        public Nullable<System.Guid> BusinessInitiativePerformanceMetrics { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
