using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Governance
    {
        public Governance()
        {
            this.GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives = new List<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives>();
            this.GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions = new List<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions>();
            this.GovernanceGovernsOver_EmployeeGoverningEmployees = new List<GovernanceGovernsOver_EmployeeGoverningEmployees>();
            this.SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy = new List<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy>();
        }

        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives> GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives { get; set; }
        public virtual ICollection<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions> GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions { get; set; }
        public virtual ICollection<GovernanceGovernsOver_EmployeeGoverningEmployees> GovernanceGovernsOver_EmployeeGoverningEmployees { get; set; }
        public virtual ICollection<SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy> SubjectAreaGovernedSubjectAreas_GovernanceGovernedBy { get; set; }
    }
}
