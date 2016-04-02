using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class MetricMockup
    {
        public MetricMockup()
        {
            this.PerformanceMetricMockupForMetric_MetricMockupMetricMockups = new List<PerformanceMetricMockupForMetric_MetricMockupMetricMockups>();
        }

        public System.Guid Oid { get; set; }
        public string MockupName { get; set; }
        public string Description { get; set; }
        public Nullable<int> Version { get; set; }
        public Nullable<System.Guid> MockupFile { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual FileData FileData { get; set; }
        public virtual ICollection<PerformanceMetricMockupForMetric_MetricMockupMetricMockups> PerformanceMetricMockupForMetric_MetricMockupMetricMockups { get; set; }
    }
}
