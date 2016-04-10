using System;
using System.Collections.Generic;
using System.Web.OData.Builder;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessFunction
    {
        public BusinessFunction()
        {
            this.BusinessGoals = new List<BusinessGoal>();
            this.BusinessInitiatives = new List<BusinessInitiative>();
            this.BusinessQuestions = new List<BusinessQuestion>();
            this.Employees = new List<Employee>();
            this.Governances = new List<Governance>();
            this.SubjectAreas = new List<SubjectArea>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BusinessGoal> BusinessGoals { get; set; }
        public virtual ICollection<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual ICollection<BusinessQuestion> BusinessQuestions { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
        public virtual ICollection<SubjectArea> SubjectAreas { get; set; }
    }
}
