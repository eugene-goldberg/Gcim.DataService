using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetric
    {
        public PerformanceMetric()
        {
            this.PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal = new List<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal>();
            this.PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives = new List<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives>();
            this.PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods = new List<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods>();
            this.PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations = new List<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations>();
            this.PerformanceMetricMockupForMetric_MetricMockupMetricMockups = new List<PerformanceMetricMockupForMetric_MetricMockupMetricMockups>();
            this.PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods = new List<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods>();
            this.PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions = new List<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions>();
            this.PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked = new List<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked>();
        }

        public System.Guid Oid { get; set; }
        public string MetricCategory { get; set; }
        public string MetricName { get; set; }
        public string MetricDefinition { get; set; }
        public string MetricPurpose { get; set; }
        public string ActionableDecisions { get; set; }
        public string Conditions { get; set; }
        public string AdditionalAnalytics { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal> PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal { get; set; }
        public virtual ICollection<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives> PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives { get; set; }
        public virtual ICollection<PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods> PerformanceMetricDataDiscoveryMethodPerformanceMetrics_DataDiscoveryMethodPerformanceMetricsDataDiscoveryMethods { get; set; }
        public virtual ICollection<PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations> PerformanceMetricMetricSupportedByThisCalculation_MetricCalculationPerformanceMetricCalculations { get; set; }
        public virtual ICollection<PerformanceMetricMockupForMetric_MetricMockupMetricMockups> PerformanceMetricMockupForMetric_MetricMockupMetricMockups { get; set; }
        public virtual ICollection<PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods> PerformanceMetricRelatedPerformanceMetrics_AnalyticalMethodRelatedAnalythicalMethods { get; set; }
        public virtual ICollection<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions> PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions { get; set; }
        public virtual ICollection<PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked> PerformanceMetricTrackingMethodPerformanceMetricsTrackingMethods_PerformanceMetricPerformanceMetricBeingTracked { get; set; }
    }
}
