using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class BusinessInitiative
    {
        public BusinessInitiative()
        {
            this.BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals = new List<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals>();
            this.BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction = new List<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction>();
            this.EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives = new List<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives>();
            this.GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives = new List<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives>();
            this.GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives = new List<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives>();
            this.PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives = new List<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives>();
            this.SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives = new List<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives>();
        }

        public System.Guid Oid { get; set; }
        public string InitiativeName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> CurrentStatus { get; set; }
        public string IsNewRecord { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals> BusinessInitiativeBusinessGoalInitiative_BusinessGoalBusinessInitiativeGoals { get; set; }
        public virtual ICollection<BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction> BusinessInitiativeSponsoredInitiatives_BusinessFunctionSponsoredByBusinessFunction { get; set; }
        public virtual ICollection<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives> EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives { get; set; }
        public virtual ICollection<GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives> GambiToolSupportedByGambiTools_BusinessInitiativeSupportsBusinessInitiatives { get; set; }
        public virtual ICollection<GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives> GovernanceBusinessInitiativeGovernance_BusinessInitiativeGovernedBusinessInitiatives { get; set; }
        public virtual ICollection<PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives> PerformanceMetricBusinessInitiativePerformanceMetrics_BusinessInitiativePerformanceMetricBusinessInitiatives { get; set; }
        public virtual ICollection<SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives> SubjectAreaBusinessInitiativeSubjectAreas_BusinessInitiativeSubjectAreaBusinessInitiatives { get; set; }
    }
}
