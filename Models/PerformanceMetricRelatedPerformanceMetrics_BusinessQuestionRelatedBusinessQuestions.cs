using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions
    {
        public Nullable<System.Guid> RelatedBusinessQuestions { get; set; }
        public Nullable<System.Guid> RelatedPerformanceMetrics { get; set; }
        public System.Guid OID { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public virtual BusinessQuestion BusinessQuestion { get; set; }
        public virtual PerformanceMetric PerformanceMetric { get; set; }
    }
}
