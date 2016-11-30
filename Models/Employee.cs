using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.DataSources = new List<DataSource>();
            this.BusinessFunctions = new List<BusinessFunction>();
            this.BusinessInitiatives = new List<BusinessInitiative>();
            this.Governances = new List<Governance>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FunctionalRole { get; set; }
        public virtual ICollection<DataSource> DataSources { get; set; }
        public virtual ICollection<BusinessFunction> BusinessFunctions { get; set; }
        public virtual ICollection<BusinessInitiative> BusinessInitiatives { get; set; }
        public virtual ICollection<Governance> Governances { get; set; }
    }
}
