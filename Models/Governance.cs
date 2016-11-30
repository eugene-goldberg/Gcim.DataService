using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Governance
    {
        public Governance()
        {
            this.InformationProducts = new List<InformationProduct>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
            this.SourceTools = new List<SourceTool>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.BusinessFunctions = new List<BusinessFunction>();
            this.BusinessInitiatives = new List<BusinessInitiative>();
            this.DataSources = new List<DataSource>();
            this.Employees = new List<Employee>();
            this.SubjectAreas = new List<SubjectArea>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<InformationProduct> InformationProducts { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
        public virtual ICollection<SourceTool> SourceTools { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }
        public virtual ICollection<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
