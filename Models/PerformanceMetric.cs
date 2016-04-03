using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class PerformanceMetric
    {
        public PerformanceMetric()
        {
            this.InformationProducts = new List<InformationProduct>();
            this.BusinessQuestions = new List<BusinessQuestion>();
            this.AnalyticalMethods = new List<AnalyticalMethod>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.BusinessGoals = new List<BusinessGoal>();
            this.DataSources = new List<DataSource>();
            this.SubjectAreas = new List<SubjectArea>();
        }

        public int ID { get; set; }
        public string Category { get; set; }
        public string MetricName { get; set; }
        public string MetricDefinition { get; set; }
        public string Description { get; set; }
        public Nullable<int> DataEntity_ID { get; set; }
        public Nullable<int> Governance_ID { get; set; }
        public Nullable<int> BusinessInitiative_ID { get; set; }
        public virtual BusinessInitiative BusinessInitiative { get; set; }
        public virtual DataEntity DataEntity { get; set; }
        public virtual Governance Governance { get; set; }
        public virtual ICollection<InformationProduct> InformationProducts { get; set; }
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual ICollection<AnalyticalMethod> AnalyticalMethods { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
