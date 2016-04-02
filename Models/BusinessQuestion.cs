using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessQuestion
    {
        public BusinessQuestion()
        {
            this.BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions = new List<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions>();
            this.BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals = new List<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals>();
            this.PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions = new List<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions>();
            this.SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions = new List<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions>();
        }

        public System.Guid Oid { get; set; }
        public string QuestionDefinition { get; set; }
        public string Comments { get; set; }
        public string RelatedSubjectArea { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions> BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public virtual ICollection<BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals> BusinessQuestionRelatedBusinessQuestions_BusinessGoalRelatedSubjectGoals { get; set; }
        public virtual ICollection<PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions> PerformanceMetricRelatedPerformanceMetrics_BusinessQuestionRelatedBusinessQuestions { get; set; }
        public virtual ICollection<SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions> SubjectAreaRelatedSubjectAreas_BusinessQuestionRelatedBusinessQuestions { get; set; }
    }
}
