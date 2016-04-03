using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessQuestion
    {
        public BusinessQuestion()
        {
            this.BusinessEntities = new List<BusinessEntity>();
            this.BusinessFunctions = new List<BusinessFunction>();
            this.BusinessGoals = new List<BusinessGoal>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.SubjectAreas = new List<SubjectArea>();
        }

        public int ID { get; set; }
        public string QuestionDefinition { get; set; }
        public string Comments { get; set; }
        public string RelatedSubjectArea { get; set; }
        public Nullable<int> AnalyticalMethod_ID { get; set; }
        public virtual AnalyticalMethod AnalyticalMethod { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
