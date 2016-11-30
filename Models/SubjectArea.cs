using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class SubjectArea
    {
        public SubjectArea()
        {
            this.Governances = new List<Governance>();
            this.BusinessEntities = new List<BusinessEntity>();
            this.BusinessFunctions = new List<BusinessFunction>();
            this.BusinessInitiatives = new List<BusinessInitiative>();
            this.BusinessQuestions = new List<BusinessQuestion>();
            this.DataEntities = new List<DataEntity>();
            this.PerformanceMetrics = new List<PerformanceMetric>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }
        public virtual ICollection<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual ICollection<DataEntity> DataEntities { get; set; }
        public virtual ICollection<PerformanceMetric> PerformanceMetrics { get; set; }
    }
}
