using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessFunction
    {
        public BusinessFunction()
        {
            this.BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions = new List<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions>();
            this.BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction = new List<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction>();
            this.BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions = new List<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions>();
            this.EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions = new List<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions>();
            this.GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions = new List<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions>();
            this.SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions = new List<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions>();
        }

        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions> BusinessGoalAssociatedBusinessGoals_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public virtual ICollection<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction> BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction { get; set; }
        public virtual ICollection<BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions> BusinessQuestionAssociatedBusinessQuestions_BusinessFunctionAssociatedBusinessFunctions { get; set; }
        public virtual ICollection<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions> EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions { get; set; }
        public virtual ICollection<GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions> GovernanceGovernedBy_BusinessFunctionGovernedBusinessFunctions { get; set; }
        public virtual ICollection<SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions> SubjectAreaAssociatedSubjectAreas_BusinessFunctionAssociatedBusinessFunctions { get; set; }
    }
}
