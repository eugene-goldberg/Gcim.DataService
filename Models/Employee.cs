using System;
using System.Collections.Generic;

namespace SelfHostedWebApiDataService.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions = new List<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions>();
            this.EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives = new List<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives>();
            this.EmployeeDataSourceOwners_DataSourceOwnsDatasources = new List<EmployeeDataSourceOwners_DataSourceOwnsDatasources>();
            this.EntityOwnedEntities_EmployeeEntityOwners = new List<EntityOwnedEntities_EmployeeEntityOwners>();
            this.GambiToolOwnsGambiTools_EmployeeToolOwners = new List<GambiToolOwnsGambiTools_EmployeeToolOwners>();
            this.GovernanceGovernsOver_EmployeeGoverningEmployees = new List<GovernanceGovernsOver_EmployeeGoverningEmployees>();
        }

        public System.Guid Oid { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FunctionalRole { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public virtual ICollection<EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions> EmployeeAssociatedEmployees_BusinessFunctionAssociatedBusinessFcuntions { get; set; }
        public virtual ICollection<EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives> EmployeeBusinessInitiativeOwner_BusinessInitiativeOwnsBusinessInitiatives { get; set; }
        public virtual ICollection<EmployeeDataSourceOwners_DataSourceOwnsDatasources> EmployeeDataSourceOwners_DataSourceOwnsDatasources { get; set; }
        public virtual ICollection<EntityOwnedEntities_EmployeeEntityOwners> EntityOwnedEntities_EmployeeEntityOwners { get; set; }
        public virtual ICollection<GambiToolOwnsGambiTools_EmployeeToolOwners> GambiToolOwnsGambiTools_EmployeeToolOwners { get; set; }
        public virtual ICollection<GovernanceGovernsOver_EmployeeGoverningEmployees> GovernanceGovernsOver_EmployeeGoverningEmployees { get; set; }
    }
}
