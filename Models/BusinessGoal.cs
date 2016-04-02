using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessGoal
    {
        public BusinessGoal()
        {
            this.BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions = new List<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions>();
            this.BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals = new List<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals>();
            this.BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals = new List<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals>();
            this.DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals = new List<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals>();
            this.PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal = new List<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal>();
        }

        public System.Guid Oid { get; set; }
        public string GoalName { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions> BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public virtual ICollection<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals> BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals { get; set; }
        public virtual ICollection<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals> BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals { get; set; }
        public virtual ICollection<DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals> DataDeliveryChannelBusinessGoalDataDeliveryChannels_BusinessGoalDataDeliveryChannelBusinessGoals { get; set; }
        public virtual ICollection<PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal> PerformanceMetricBusinessGoalPerformanceMetrics_BusinessGoalPerformanceMetricsBusinessGoal { get; set; }
    }
}
