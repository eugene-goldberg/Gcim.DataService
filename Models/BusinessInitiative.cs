using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessInitiative
    {
        public BusinessInitiative()
        {
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.SourceTools = new List<SourceTool>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.BusinessFunctions = new List<BusinessFunction>();
            this.BusinessGoals = new List<BusinessGoal>();
            this.Employees = new List<Employee>();
            this.Governances = new List<Governance>();
            this.SubjectAreas = new List<SubjectArea>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Status { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
